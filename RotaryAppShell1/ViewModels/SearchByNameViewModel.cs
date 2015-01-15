using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Kiosk.Views;

namespace Kiosk.ViewModels
{
    class SearchByNameViewModel : ViewModelBase
    {
        private readonly MasterWindowViewModel parentVm;
        public SearchByNameViewModel(MasterWindowViewModel parentVm)
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
                                                    //parentVm.NavBack();
                                                    parentVm.CurrentUserControl = new HomeView(this.parentVm);
                                                    break;
                                                }

                                                case "searchMap":
                                                {
                                                    parentVm.CurrentUserControl = new SearchByCountryView(this.parentVm);
                                                    break;
                                                }

                                                case "searchVideo":
                                                {
                                                    parentVm.CurrentUserControl = new SearchByVideoView(this.parentVm);
                                                    break;
                                                }
                                              }
                                          }));
            }
        }
    }
}
