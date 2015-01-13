using Kiosk.ViewModels;
using System.Windows.Controls;

namespace Kiosk.Views
{
    /// <summary>
    /// Interaction logic for AboutInfoView.xaml
    /// </summary>
    public partial class AboutInfoView : UserControl
    {
        public AboutInfoView(MasterWindowViewModel mwvm)
        {
            InitializeComponent();
            DataContext = new AboutInfoViewModel(mwvm);
        }
    }
}
