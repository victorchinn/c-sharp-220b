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

namespace MenuWindow
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

        private void OnNew_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("New command");
        }
        private void OnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        // Click Ctrl-N to execute the shortcut.
        private void OnNew_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // Set this to false if the New command is not available
            e.CanExecute = true;
        }

    }
}
