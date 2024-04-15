using ServisniProtokolGažík.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokolGažík.Models
{
    public class Mereni : IHtmlUlozitelne
    {
        public string _parametr { get; set; }
        public double _namerenaHodnota { get; set; }
        public string _jednotka { get; set; }
        public bool _vyhovuje { get; set; }

        public string DefinovatCssStyl()
        {
            return """"
                <style>
                .mereniHeader {
                    font-weight: bold;
                    font-size: larger;
                }
                .mereniHeader, .mereniContent > div {
                    display: flex;
                    flex-direction: row;
                    justify-content: space-between;
                    padding: 0 20px;
                }
                .mereniContent > div {
                    display: flex;
                    flex-direction: row;
                }
                .mereni {
                    grid-column: 1 / 3;
                    border: 1px solid black;
                    width: 90% !important;
                    height: 180px !important;
                }
                </style>
                """"; ;
        }

        public string PrevedNaHtml()
        {
            return $"""
                <div>
                    <div>{this._parametr}</div>
                    <div>{this._namerenaHodnota}</div>
                    <div>{this._jednotka}</div>
                    <div>{(this._vyhovuje ? "ANO" : "NE")}</div>
                </div>
                """;
        }

    }
}
