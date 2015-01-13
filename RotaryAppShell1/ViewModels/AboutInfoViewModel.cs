using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Kiosk.Models;
using Kiosk.Views;

namespace Kiosk.ViewModels
{
    class AboutInfoViewModel : ViewModelBase
    {
        private readonly MasterWindowViewModel parentVm;

        private List<AboutInfo> aboutPages;
        public AboutInfoViewModel(MasterWindowViewModel parentVm)
        {
            this.parentVm = parentVm;

            //load the about pagers from the xml
            aboutPages = LoadAboutPagesFromXML();
        }

        private List<AboutInfo> LoadAboutPagesFromXML()
        {
            List<AboutInfo> allPages = new List<AboutInfo>();

            String aboutConfig = @"C:\Clients\Rotary\rotary demos\rotary demos\WPF\RotaryAppShell1\RotaryAppShell1\Config\About Pages.xml";
            //@"file://vmware-host/Shared%20Folders/Documents/dev/WPF/RotaryAppShell1/RotaryAppShell1/Config/About Pages.xml";

            var aboutPages = from page in XDocument.Load(aboutConfig).DescendantNodes() select page;
            
            foreach (var page in aboutPages)
            {
                AboutInfo ai = new AboutInfo();
                allPages.Add(ai);
            }

            return allPages;
        }

        private RelayCommand<string> navToNewControlCommand;
        public GalaSoft.MvvmLight.Command.RelayCommand<string> NavToNewControlCommand
        {
            get
            {
                return navToNewControlCommand
                    ?? (navToNewControlCommand = new RelayCommand<string>(
                                          val =>
                                          {
                                              switch (val)
                                              {
                                                  case "Back":
                                                  {
                                                      parentVm.CurrentUserControl = new HomeView(parentVm);
                                                      break;
                                                  }
                                              }
                                          }));
            }
        }
    }
}
