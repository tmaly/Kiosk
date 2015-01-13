using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Kiosk.Views;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;

namespace Kiosk.ViewModels
{
    class HomeViewModel : ViewModelBase
    {
        private MasterWindowViewModel parentVM;
        
        public HomeViewModel(MasterWindowViewModel mwvm)
        {
            parentVM = mwvm;
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
                                                  case "AboutInfoView":
                                                  {
                                                      parentVM.CurrentUserControl = new AboutInfoView(parentVM);
                                                      break;
                                                  }

                                                  case "SearchByTextEntryView":
                                                  {
                                                      parentVM.CurrentUserControl = new SearchByTextEntryView(parentVM);
                                                      break;
                                                  }

                                                  case "WelcomeVideoView":
                                                  {
                                                      parentVM.CurrentUserControl = new WelcomeVideoView(parentVM);
                                                      break;
                                                  }
                                              }
                                          }));
            }
        }
    }
}
