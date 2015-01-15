using Kiosk.ViewModels;
using System.Windows.Controls;

namespace Kiosk.Views
{
    /// <summary>
    /// Interaction logic for SearchByVideoView.xaml
    /// </summary>
    public partial class SearchByVideoView : UserControl
    {
        public SearchByVideoView(MasterWindowViewModel mwvm)
        {
            InitializeComponent();
            DataContext = new SearchByVideoViewModel(mwvm);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
