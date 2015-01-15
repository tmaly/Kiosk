using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
//using Kiosk.Annotations;
using Kiosk.Views;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace Kiosk.ViewModels
{
    class WelcomeVideoViewModel : ViewModelBase
    {
        private readonly MasterWindowViewModel parentVm;
        public WelcomeVideoViewModel(MasterWindowViewModel parentVm)
        {
            this.parentVm = parentVm;
        }

        public string videoPath
        {
            get 
            {
                return @"C:\Clients\Rotary\Kiosk\Assests\Video\ThisCloseHD.mp4";
            }
        }

        private RelayCommand<string> navToNewControlCommand;
        public RelayCommand<string> NavToNewControlCommand
        {
            get
            {
                return navToNewControlCommand
                    ?? (navToNewControlCommand = new RelayCommand<string>(
                                          val =>
                                          {
                                              switch (val)
                                              {
                                                  case "Home":
                                                  {
                                                      parentVm.NavBack();
                                                      break;
                                                  }

                                                  case "ViewVideo":
                                                  {
                                                      MessageBox.Show("Enjoy the show");
                                                      break;
                                                  }
                                              }
                                          }));
            }
        }
    }
}
