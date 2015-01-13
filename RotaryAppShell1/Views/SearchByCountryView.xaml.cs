using Kiosk.ViewModels;
using System.Windows.Controls;

namespace Kiosk.Views
{
    /// <summary>
    /// Interaction logic for SearchByCountryView.xaml
    /// </summary>
    public partial class SearchByCountryView : UserControl
    {
        public SearchByCountryView()
        {
            InitializeComponent();
            DataContext = new SearchByCountryViewModel();
        }
    }
}
