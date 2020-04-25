using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MenuWindow
{
    /// <summary>
    /// Interaction logic for NavigatorWindow.xaml
    /// </summary>
    public partial class NavigatorWindow : Window
    {
        public NavigatorWindow()
        {
            InitializeComponent();
        }

        private void GoToButton_Click(object sender, RoutedEventArgs e)
        {
            // Convert the Uri into a string
            //            var fileName = e.Uri.AbsoluteUri;

            string _fileName = "http:\\www." + TextBlockEnterAddress.Text;
            // Pass the fileName to the helper class
            var processStartInfo = new ProcessStartInfo(_fileName)
            {
                UseShellExecute = true,
                Verb = "open",
            };

            // Start a new process
            Process.Start(processStartInfo);

        }

        private void uxNavigator_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            // Convert the Uri into a string
            var fileName = e.Uri.AbsoluteUri;

            // Pass the fileName to the helper class
            var processStartInfo = new ProcessStartInfo(fileName)
            {
                UseShellExecute = true,
                Verb = "open",
            };

            // Start a new process
            Process.Start(processStartInfo);
        }
    }
}
