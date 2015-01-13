using Kiosk.ViewModels;
using System.Windows.Controls;

namespace Kiosk.Views
{
    /// <summary>
    /// Interaction logic for SearchByTextEntryView.xaml
    /// </summary>
    public partial class SearchByTextEntryView : UserControl
    {
        public SearchByTextEntryView(MasterWindowViewModel mwvm)
        {
            InitializeComponent();
            DataContext = new SearchByNameViewModel(mwvm);
        }
    }
}
