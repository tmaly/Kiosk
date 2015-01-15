using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using Kiosk.Common.XML;
using GalaSoft.MvvmLight.Command;

namespace Kiosk.Models
{
    class AboutInfo : ObservableObject
    {
        public String Name { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public List<String> Images { get; set; }
        public List<String> PdfImages { get; set; }
        public String Video { get; set; }
    }

    public class AboutButton : ObservableObject
    {
        public AboutButton() { }

        [XMLParser("ows_ID")]
        public String ID { get; set; }

        [XMLParser("ows_DisplayTitleRI")]
        public String Name { get; set; }

        [XMLParser("ows_LinkTitle")]
        public String Command { get; set; }

        public RelayCommand<string> VMLink { get; set; }
    }

}
