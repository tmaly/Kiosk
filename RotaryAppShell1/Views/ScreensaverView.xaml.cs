using Kiosk.ViewModels;
using System.Windows.Controls;

namespace Kiosk.Views
{
    /// <summary>
    /// Interaction logic for ScreensaverView.xaml
    /// </summary>
    public partial class ScreensaverView : UserControl
    {
        public ScreensaverView()
        {
            InitializeComponent();
            DataContext = new ScreensaverViewModel();
        }
    }
}
