﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

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
}
