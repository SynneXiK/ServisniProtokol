using ServisniProtokolGažík.Models.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;

namespace ServisniProtokolGažík.Models
{
    [XmlInclude(typeof(ArrayList))]
    public class ServisniProtokol : IVykreslitelne, IHtmlUlozitelne
    {
        public string _cisloProtokolu;
        public DateOnly _datumMereni;
        public Zakaznik _zakaznik = new Zakaznik();
        public Zarizeni _zarizeni = new Zarizeni();
        [XmlArray("Mereni")]
        [XmlArrayItem("Mereni", typeof(Mereni))]
        public ArrayList _mereni = new ArrayList();

        public ServisniProtokol()
        {
                
        }
        public string DefinovatCssStyl()
        {
            return """"
                            <style>
                    body {
                        font-size: large;
                        margin: 20px;
                        display: flex;
                        flex-direction: column;
                        align-items: center;
                    }
                    h1, h2 {
                        text-align: center;
                    }
                    .generalInfo {
                    display: flex;
                    flex-direction: row;
                    gap: 20px;
                    }
                    .generalInfo >div {
                    display: flex;
                    flex-direction: row;
                    align-items: center;
                    gap: 5px;
                    }
                    .content {
                        display: grid;
                        grid-template-columns: 1fr 1fr;
                        grid-template-rows: 1fr 1fr;
                        width: 100%;
                        place-items: center;
                        height: 600px;
                    }
                    .content > div {
                        width: 80%;
                        height: 150px;
                    }
                    .upperBoxes {
                        border: 1px solid black;
                        padding: 20px;
                        height: 100%;
                    }
                    .upperBoxes > div {
                        display: flex;
                        flex-direction: row;
                        gap: 20px;
                        justify-content: flex-start;
                        align-items: center;
                        padding-left: 20px;
                        height: 25%;
                    }
                </style>
                """";
        }

        public string PrevedNaHtml()
        {
            string ret = $"""
                <!DOCTYPE html>
                <html lang="en">
                <head>
                    <meta charset="UTF-8">
                    <title>Export</title>
                    {this.DefinovatCssStyl()}
                    ***
                </head>
                <body>
                    <h1>Náhled</h1>
                    <div class="generalInfo">
                    <div>
                        <h3>Číslo Protokolu:</h3>
                        <div>{this._cisloProtokolu}</div>
                    </div>
                    <div>
                        <h3>Datum Měření:</h3>
                        <div>{this._datumMereni.ToString()}</div>
                    </div>
                </div>
                <div class="content">
                    <div class="contentDiv">
                        <h2>Zákazník</h2>
                        {this._zakaznik.PrevedNaHtml()}
                    </div>
                    <div>
                        <h2>Zařízení</h2>
                        {this._zarizeni.PrevedNaHtml()}
                    </div>
                    <div class="mereni">
                        <h2>Měření</h2>
                        ###
                    </div>
                </div>
                    <h1>Zařízení {(Vyhovuje() ? "je" : "není")} schopné dalšího provozu</h1>

                </body>
                </html>
                """;
            StringBuilder sb = new StringBuilder();
            string style = "";
            sb.Append("""
                    <div>
                <div class="mereniHeader">
                    <div>Parametr</div>
                    <div>Naměřená Hodnota</div>
                    <div>Jednotka</div>
                    <div>Vyhovuje</div>
                </div>
                <div class="mereniContent">
                """);
            foreach (Mereni item in this._mereni)
            {
                sb.Append(item.PrevedNaHtml());
                style = item.DefinovatCssStyl();
            }
            sb.Append("""
                </div>
                </div>
                """);
            ret =  Regex.Replace(ret, @"###", sb.ToString());
            return Regex.Replace(ret, @"\*\*\*", style);
        }

        public void Vykresli(Graphics g)
        {
            int margin = 20;
            int height = 850;
            int width = 700;
            System.Drawing.Font headerFont = new System.Drawing.Font("Calibri", 36, FontStyle.Bold);
            System.Drawing.Font smallerHeader = new System.Drawing.Font("Calibri", 24, FontStyle.Bold);
            System.Drawing.Font xsmallHeader = new System.Drawing.Font("Calibri", 20, FontStyle.Bold);
            System.Drawing.Font props = new System.Drawing.Font("Calibri", 18);

            g.DrawRectangle(Pens.Black, margin, margin, width, height);
            SizeF nahledSz = g.MeasureString("Náhled", headerFont);
            g.DrawString("Náhled", headerFont, Brushes.Black, margin + width / 2 - nahledSz.Width / 2, margin);

            SizeF cisloProtSz = g.MeasureString("Číslo Protokolu:", xsmallHeader);
            g.DrawString("Číslo Protokolu:", xsmallHeader, Brushes.Black, 2*margin, 5*margin);
            g.DrawString(this._cisloProtokolu, props, Brushes.Black, 3 * margin + cisloProtSz.Width, 5 * margin);

            SizeF datumMereniSz = g.MeasureString("Datum Měření:", xsmallHeader);
            g.DrawString("Datum Měření:", xsmallHeader, Brushes.Black, width - 6 * margin - datumMereniSz.Width, 5 * margin);
            g.DrawString(this._datumMereni.ToString(), props, Brushes.Black, width - 6 * margin, 5 * margin);

            g.DrawRectangle(Pens.Black, 2 * margin, 12*margin, width / 2.5f, height / 3); // zakaznik box
            SizeF zakaznikSz = g.MeasureString("Zákazník", smallerHeader);
            g.DrawString("Zákazník", smallerHeader, Brushes.Black, 6 * margin , 10 * margin );
            
            g.DrawString("Název:", props, Brushes.Black, 2 * margin, 13 * margin);
            g.DrawString(this._zakaznik._nazev, props, Brushes.Black, 6 * margin, 13 * margin);

            g.DrawString("Adresa:", props, Brushes.Black, 2 * margin, 15 * margin);
            g.DrawString(this._zakaznik._adresa, props, Brushes.Black, 6 * margin, 15 * margin);

            g.DrawString("PSČ:", props, Brushes.Black, 2 * margin, 17 * margin);
            g.DrawString(this._zakaznik._psc, props, Brushes.Black, 6 * margin, 17 * margin);

            g.DrawString("IC:", props, Brushes.Black, 2 * margin, 19 * margin);
            g.DrawString(this._zakaznik._ic, props, Brushes.Black, 6 * margin, 19 * margin);


            g.DrawRectangle(Pens.Black, 2 * margin + width / 2.5f + 4*margin , 12 * margin, width / 2.5f, height / 3); // zarizeni box
            SizeF zarizeniSz = g.MeasureString("Zákazník", smallerHeader);
            g.DrawString("Zařízení", smallerHeader, Brushes.Black, 8 * margin + width / 2.5f + 4 * margin, 10 * margin);

            g.DrawString("Výrobce:", props, Brushes.Black, 3 * margin + width / 2.5f + 4 * margin, 13 * margin);
            g.DrawString(this._zarizeni._vyrobce, props, Brushes.Black, 8 * margin + width / 2.5f + 4 * margin, 13 * margin);

            g.DrawString("Model:", props, Brushes.Black, 3 * margin + width / 2.5f + 4 * margin, 15 * margin);
            g.DrawString(this._zarizeni._model, props, Brushes.Black, 8 * margin + width / 2.5f + 4 * margin, 15 * margin);

            g.DrawString("Sériové Číslo:", props, Brushes.Black, 3 * margin + width / 2.5f + 4 * margin, 17 * margin);
            g.DrawString(this._zarizeni._serioveCislo, props, Brushes.Black, 10 * margin + width / 2.5f + 4 * margin, 17 * margin);


            g.DrawRectangle(Pens.Black, 2 * margin, 11 * margin + width / 2, width - 3 * margin, height / 3); // mereni box
            SizeF mereniSz = g.MeasureString("Měření", smallerHeader);
            g.DrawString("Měření", smallerHeader, Brushes.Black, 2 * margin, 11 * margin + width / 2 - 2* margin);

            g.DrawString("Parametr", xsmallHeader, Brushes.Black, 2 * margin, 11 * margin + width / 2);
            g.DrawString("Naměřená Hodnota", xsmallHeader, Brushes.Black, 8 * margin, 11 * margin + width / 2);
            g.DrawString("Jednotka", xsmallHeader, Brushes.Black, 21 * margin, 11 * margin + width / 2);
            g.DrawString("Vyhovuje", xsmallHeader, Brushes.Black, 27 * margin, 11 * margin + width / 2);

            int lineBonus = 2;
            foreach (Mereni item in this._mereni)
            {
                g.DrawString(item._parametr, xsmallHeader, Brushes.Black, 2 * margin, 11 * margin + width / 2 + margin * lineBonus);
                g.DrawString(item._namerenaHodnota.ToString(), xsmallHeader, Brushes.Black, 9 * margin, 11 * margin + width / 2 + margin * lineBonus);
                g.DrawString(item._jednotka, xsmallHeader, Brushes.Black, 21 * margin, 11 * margin + width / 2 + margin * lineBonus);
                g.DrawString(item._vyhovuje ? "ANO" : "NE", xsmallHeader, Brushes.Black, 27 * margin, 11 * margin + width / 2 + margin * lineBonus);

                lineBonus += 2;
            }           
            string schopneProv = "Zařízení " + (Vyhovuje() ? "je" : "není") + " schopné dalšího provozu";
            SizeF schopSz = g.MeasureString(schopneProv, smallerHeader);
            g.DrawString(schopneProv, smallerHeader, Brushes.Black, width / 2 - schopSz.Width / 2 , height - 3 * margin);

        }
        public bool Vyhovuje()
        {
            foreach (Mereni item in this._mereni) // arraylist nema lambda foreach BRUH A HLAVNĚ NEMÁ Any() ;((
            {
                if (item._vyhovuje == false)
                    return false;
            }
            return true;
        }
    }
}
