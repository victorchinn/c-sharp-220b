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

namespace ThumbsUp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Models.User user = new Models.User();

        public MainWindow()
        {
            InitializeComponent();
            MainScreenWindow.DataContext = user;
//            uxName.DataContext = user;
//            uxNameError.DataContext = user;
//            uxPassword.DataContext = user;
//            uxPasswordError.DataContext = user;
        }

        private void MAX_Window_Button_Click(object sender, RoutedEventArgs e)
        {
            if (MainScreenWindow.WindowState == WindowState.Maximized)
            {
                MainScreenWindow.WindowState = WindowState.Normal;
            }
            else
            {
                MainScreenWindow.WindowState = WindowState.Maximized;
            }
        }

    }
}
