using ServisniProtokolGažík.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokolGažík.Models
{
    public class Zarizeni : IHtmlUlozitelne
    {
        public string _vyrobce;
        public string _model;
        public string _serioveCislo;

        public string DefinovatCssStyl()
        {
            return "";
        }

        public string PrevedNaHtml()
        {
            return $"""
                <div class="upperBoxes">
                <div>
                    <h3>Výrobce:</h3>
                    <p>{this._vyrobce}</p>
                </div>
                <div>
                    <h3>Model:</h3>
                    <p>{this._model}</p>
                </div>
                <div>
                    <h3>Sériové číslo:</h3>
                    <p>{this._serioveCislo}</p>
                </div>
                </div>
                """;
        }

    }
}
