using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk.Common.XML
{
    public class XMLParserAttribute : Attribute
    {
        public string Name { get; set; }
        public XMLParserAttribute(string attributeName)
        {
            this.Name = attributeName;
        }
    }
}
