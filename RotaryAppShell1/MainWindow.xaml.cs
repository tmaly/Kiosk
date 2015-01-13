using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Kiosk.ViewModels;
using Kiosk.Views;

namespace Kiosk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //NavigationController.Frame = mainFrame;

            this.KeyDown += MainWindow_KeyDown;


            var mwvm = new MasterWindowViewModel(mainFrame);
            DataContext = mwvm;
            mwvm.CurrentUserControl = new HomeView(mwvm);
        }

        void MainWindow_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Escape)
            {
                App.Current.Shutdown(0);
            }
        }
    }
}
