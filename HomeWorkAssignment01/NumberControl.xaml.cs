using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeWorkAssignment01
{
    /// <summary>
    /// Interaction logic for NumberControl.xaml
    /// </summary>
    public partial class NumberControl : UserControl
    {
        public NumberControl()
        {
            InitializeComponent();
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
//            var value = uxNumber.Value;
//            MessageBox.Show("Your number is " + value);
        }

        private void uxNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}
