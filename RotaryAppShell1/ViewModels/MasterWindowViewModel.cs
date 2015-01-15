using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Kiosk.Views;

namespace Kiosk.ViewModels
{
    public class MasterWindowViewModel : ViewModelBase
    {
        private readonly Frame contentFrame;
        private UserControl currentUserControl;
        private UserControl previousUserControl;
        private Dictionary<string, Action<MasterWindowViewModel>> navMap;

        public MasterWindowViewModel(Frame contentFrame)
        {
            LoadMap();

            this.contentFrame = contentFrame;
            currentUserControl = new HomeView(this);
        }


        public UserControl CurrentUserControl
        {
            get { return currentUserControl; }
            set
            {
                previousUserControl = currentUserControl;
                currentUserControl = value;
                contentFrame.Navigate(currentUserControl);
            }
        }


        internal void NavBack()
        {
            CurrentUserControl = previousUserControl;
        }

        public void NavTo(string destination)
        {
            Action<MasterWindowViewModel> tmp;
            if (navMap.TryGetValue(destination, out tmp))
            {
                tmp(this);
            }
        }

        private void LoadMap()
        {
            navMap = new Dictionary<string, Action<MasterWindowViewModel>>();
            navMap.Add("Home", p => p.CurrentUserControl = new HomeView(p));
            navMap.Add("searchName", p => p.CurrentUserControl = new SearchByTextEntryView(p));
            navMap.Add("searchMap", p => p.CurrentUserControl = new SearchByCountryView(p));
            navMap.Add("searchVideo", p => p.CurrentUserControl = new SearchByVideoView(p));
        }
    }
}
