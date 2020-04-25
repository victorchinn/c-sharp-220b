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
using System.Windows.Shapes;

namespace MenuWindow
{
    /// <summary>
    /// Interaction logic for StatusWindow.xaml
    /// </summary>
    public partial class StatusWindow : Window
    {
        public StatusWindow()
        {
            InitializeComponent();
            MAX_CHARS.Text = _MAX_CHARS_IN_TEXT.ToString();
            uxProgressBar.Maximum = Convert.ToDouble(MAX_CHARS.Text); // Set the maximum
        }
        private int _MAX_CHARS_IN_TEXT = 100;

        private void uxTextEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int row = uxTextEditor.GetLineIndexFromCharacterIndex(uxTextEditor.CaretIndex);
            int col = uxTextEditor.CaretIndex - uxTextEditor.GetCharacterIndexFromLineIndex(row);
            uxStatus.Text = "Line " + (row + 1) + ", Char " + (col + 1);

            uxProgressBar.Value = (uxTextEditor.Text.Length / uxProgressBar.Maximum) * 100; // Set the progressbar
        }

        private void MAX_CHARS_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
