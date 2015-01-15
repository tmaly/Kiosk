using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiosk.Common.XML;
using Kiosk.Models;
using System.Xml.Linq;


namespace Kiosk.DAL
{
    public class XMLDataParser
    {
        public List<T> Collect<T>()
        {
            var parsedData = new List<T>();

            // Need to create a map here to link T to an object containing 
            // the info. required to extract all attributes.
            String aboutConfig = @"C:\Clients\Rotary\rotary demos\rotary demos\WPF\RotaryAppShell1\RotaryAppShell1\Config\About Pages.xml";

            var rows = from data in XDocument.Load(aboutConfig).Descendants()
                       where data.Name.Namespace == "#RowsetSchema"
                       select data;
            
            foreach (var row in rows)
            {
                var target = (T)Activator.CreateInstance(typeof(T));
                foreach (var p in target.GetType().GetProperties())
                {
                    if (p.CustomAttributes.Count() > 0)
                    {
                        var ca = p.GetCustomAttributes(typeof(XMLParserAttribute), false);
                        if (ca != null)
                        {
                            var attr = row.Attribute(((XMLParserAttribute)ca.First()).Name);
                            p.SetValue(target, attr.Value);
                        }
                    }
                }
                parsedData.Add(target);
            }

            return parsedData;
        }
    }
}
