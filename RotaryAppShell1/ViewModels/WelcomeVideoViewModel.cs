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

namespace Kiosk.ViewModels
{
    class WelcomeVideoViewModel : ViewModelBase
    {
        private readonly MasterWindowViewModel parentVm;
        public WelcomeVideoViewModel(MasterWindowViewModel parentVm)
        {
            this.parentVm = parentVm;
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
