using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using GalaSoft.MvvmLight;

namespace Kiosk.Models
{
    public class DonorLevel : ObservableObject
    {
        public String Name { get; set; }
        public String Description { get; set; }
    }
}
