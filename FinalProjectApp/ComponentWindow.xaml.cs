﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using FinalProjectApp.Models;

namespace FinalProjectApp
{
    /// <summary>
    /// Interaction logic for ComponentWindow.xaml
    /// </summary>
    public partial class ComponentWindow : Window
    {
        public ComponentWindow()
        {
            InitializeComponent();
            // Don't show this window in the task bar
            ShowInTaskbar = false;
        }

        public ComponentModel Component { get; set; }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            // Original code that existed BEFORE binding was introduced 
            //            Component = new ComponentModel();
            //            Component.Name = uxName.Text;

            //        public int Id { get; set; }
            //        public string Name { get; set; }
            //        public string Email { get; set; }                 -- PartNumber
            //        public string PhoneType { get; set; }             -- Type
            //        public string PhoneNumber { get; set; }           -- MemberOf
            //        public int Age { get; set; }                      -- Description
            //        public string Notes { get; set; }
            //        public System.DateTime CreatedDate { get; set; }

            // Original code that existed BEFORE binding was introduced 
            //            Component.PartNumber = uxEmail.Text;

            if (uxAssembly.IsChecked.Value)
            {
                Component.Type = "Assembly";
            }
            else
            {
                Component.Type = "Component";
            }

            // Original code that existed BEFORE binding was introduced 
            // Component.MemberOf = uxPhoneNumber.Text;
            // Component.Description = "0";
            // Component.Notes = uxNotes.Text;
            // Component.CreatedDate = DateTime.Now;

            // This is the return value of ShowDialog( ) below
            DialogResult = true;
            Close();
        }

        private void uxCancel_Click(object sender, RoutedEventArgs e)
        {
            // This is the return value of ShowDialog( ) below
            DialogResult = false;
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Component != null)
            {
                if (Component.Type == "Home")
                {
                    uxAssembly.IsChecked = true;
                }
                else
                {
                    uxComponent.IsChecked = true;
                }
                uxSubmit.Content = "Update";
            }
            else
            {
                Component = new ComponentModel();
                Component.CreatedDate = DateTime.Now;
            }

            uxGrid.DataContext = Component;
        }

        private void uxPartNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            // SEE IF KEYS ARE NUMERIC, A DASH, OR AN UPPERCASE CHARACTER

            if (e.Text == "-")
            {
                // DASH IS OK
                return;
            }

            char _CharacterKey = e.Text[0];

            if (((Char.IsDigit(_CharacterKey) == true) || ((Char.IsLetter(_CharacterKey) && (Char.IsUpper(_CharacterKey))))))
            {
                if (uxPartNumber.Text.Length > 10)
                {
                    e.Handled = true;
                }

                return;
            }
            else
            {
                // CONSUME THE INVALID KEY
                e.Handled = true;
            }
        }
    }
}
