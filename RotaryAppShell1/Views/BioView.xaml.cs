using Kiosk.ViewModels;
using System.Windows.Controls;

namespace Kiosk.Views
{
    /// <summary>
    /// Interaction logic for BioView.xaml
    /// </summary>
    public partial class BioView : UserControl
    {
        public BioView()
        {
            InitializeComponent();
            DataContext = new BioViewModel();
        }
    }
}
