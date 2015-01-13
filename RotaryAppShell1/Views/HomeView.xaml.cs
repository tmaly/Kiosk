using Kiosk.ViewModels;
using System.Windows.Controls;

namespace Kiosk.Views
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView(MasterWindowViewModel mwvm)
        {
            InitializeComponent();
            DataContext = new HomeViewModel(mwvm);
        }
    }
}
