﻿using System;
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

namespace HomeWorkAssignment01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Submitting password:" + uxPassword.Text);
        }

        private void uxName_OR_uxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            // HANDLE CHECK TO ENABLE/DISABLE THE SUBMIT BUTTON
            // changing either text uxName or uxPassword will call this method

            if ((uxName.Text == "") || (uxPassword.Text == ""))
            {
//                uxSubmit.IsEnabled = false;
            }
            else
            {
//                uxSubmit.IsEnabled = true;
            };
        }
    }
}
