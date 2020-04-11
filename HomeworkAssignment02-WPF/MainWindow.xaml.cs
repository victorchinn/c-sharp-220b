using HomeworkAssignment02_WPF.Models;
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

namespace HomeworkAssignment02_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ViewModel MainAppViewModel = new ViewModel();


        public MainWindow()
        {
            InitializeComponent();
            MainWindowView.DataContext = MainAppViewModel;
        }

        private void LoadList_Click(object sender, RoutedEventArgs e)
        {
            MainAppViewModel.LoadInitialData();
        }

        private void First_Action_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Second_Action_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Third_Action_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Fourth_Action_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
