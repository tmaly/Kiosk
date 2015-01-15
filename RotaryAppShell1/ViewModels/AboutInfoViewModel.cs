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
using System.Collections.ObjectModel;
using Kiosk.DAL;

namespace Kiosk.ViewModels
{
    class AboutInfoViewModel : ViewModelBase
    {
        private readonly MasterWindowViewModel parentVm;

        private IDictionary<string, Action<MasterWindowViewModel>> navGuide;

        private List<AboutInfo> aboutPages;
        public AboutInfoViewModel(MasterWindowViewModel parentVm)
        {
            this.parentVm = parentVm;
            LoadAboutPagesFromXML();
        }

        private void LoadAboutPagesFromXML()
        {
            var data  = new XMLDataParser().Collect<AboutButton>();
            data.ForEach(x => 
            {
                x.VMLink = this.NavToNewControlCommand;
                _aboutData.Add(x);
            });

            _aboutData.Add(new AboutButton { Command = "Home", Name = "Home", ID = "2", VMLink = this.NavToNewControlCommand }); 
        }

        private readonly ObservableCollection<AboutButton> _aboutData = new ObservableCollection<AboutButton>();
        public ObservableCollection<AboutButton> ButtonList { get { return _aboutData; } }

        private RelayCommand<string> navToNewControlCommand;
        public RelayCommand<string> NavToNewControlCommand
        {
            get
            {
                return navToNewControlCommand ?? (navToNewControlCommand = new RelayCommand<string>(
                                          val => this.parentVm.NavTo(val)));
            }
        }
    }
}
