using Kiosk.ViewModels;
using System.Windows.Controls;

namespace Kiosk.Views
{
    /// <summary>
    /// Interaction logic for WelcomeVideoView.xaml
    /// </summary>
    public partial class WelcomeVideoView : UserControl
    {
        public WelcomeVideoView(MasterWindowViewModel mwvm)
        {
            InitializeComponent();
            DataContext = new WelcomeVideoViewModel(mwvm);
        }
    }
}
