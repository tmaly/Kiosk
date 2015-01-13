using Kiosk.ViewModels;
using System.Windows.Controls;

namespace Kiosk.Views
{
    /// <summary>
    /// Interaction logic for SearchByVideoView.xaml
    /// </summary>
    public partial class SearchByVideoView : UserControl
    {
        public SearchByVideoView()
        {
            InitializeComponent();
            DataContext = new SearchByVideoViewModel();
        }
    }
}
