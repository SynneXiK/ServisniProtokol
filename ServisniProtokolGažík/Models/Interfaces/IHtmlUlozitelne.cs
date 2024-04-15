using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokolGažík.Models.Interfaces
{
    public interface IHtmlUlozitelne
    {
        public string PrevedNaHtml();
        public string DefinovatCssStyl();
    }
}
