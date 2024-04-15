using ServisniProtokolGažík.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokolGažík.Models
{
    public class Zakaznik : IHtmlUlozitelne
    {
        public string _nazev = "";
        public string _adresa = "";
        public string _psc = "";
        public string _ic = "";

        public string DefinovatCssStyl()
        {
            return ""; // css jsem dělal obecně, jen mereni ma svoje
        }

        public string PrevedNaHtml()
        {
            return $"""
                <div class="upperBoxes">
                    <div>
                        <h3>Název:</h3>
                        <p>{this._nazev}</p>
                    </div>
                    <div>
                        <h3>Adresa:</h3>
                        <p>{this._adresa}</p>
                    </div>
                    <div>
                        <h3>PSČ:</h3>
                        <p>{this._psc}</p>
                    </div>
                    <div>
                        <h3>IC:</h3>
                        <p>{this._ic}</p>
                    </div>
                </div>
                """;
        }


    }
}
