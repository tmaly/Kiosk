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

        public MasterWindowViewModel(Frame contentFrame)
        {
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
    }
}
