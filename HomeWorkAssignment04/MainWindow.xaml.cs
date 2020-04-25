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

namespace HomeWorkAssignment04
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

        private void EnterZipCode_TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
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
                if (EnterZipCode_TextBox.Text.Length > 10)
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

        private void EnterZipCode_TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            int _InputTextLength = EnterZipCode_TextBox.Text.Length;
            double number1;
            double number2;

            switch (_InputTextLength)
            {

                case 5:

                    if (double.TryParse(EnterZipCode_TextBox.Text.Substring(0, 5), out number1))
                    {
                        // ALL NUMERIC ... GOOD!!
                        Submit_Button.IsEnabled = true;
                    }
                    else
                    {
                        // NOT GOOD!!
                        Submit_Button.IsEnabled = false;
                    }
                    break;

                case 6:
                    if (Char.IsLetter((Char)EnterZipCode_TextBox.Text[0]))
                    {
                        if (Char.IsDigit((Char)EnterZipCode_TextBox.Text[1]))
                        {
                            if (Char.IsLetter((Char)EnterZipCode_TextBox.Text[2]))
                            {
                                if (Char.IsDigit((Char)EnterZipCode_TextBox.Text[3]))
                                {
                                    if (Char.IsLetter((Char)EnterZipCode_TextBox.Text[4]))
                                    {
                                        if (Char.IsDigit((Char)EnterZipCode_TextBox.Text[5]))
                                        {
                                            // ALL NUMERIC ... GOOD!!
                                            Submit_Button.IsEnabled = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        // NOT GOOD!!
                        Submit_Button.IsEnabled = false;
                    }
                    break;

                case 10:

                    if (EnterZipCode_TextBox.Text.Substring(5, 1) == "-")
                    {
                        if (double.TryParse(EnterZipCode_TextBox.Text.Substring(0, 5), out number1))
                        {
                            if (double.TryParse(EnterZipCode_TextBox.Text.Substring(6, 4), out number2))
                                // ALL NUMERIC ... GOOD!!
                                Submit_Button.IsEnabled = true;
                        }
                    }
                    else
                    {
                        // NOT GOOD!!
                        Submit_Button.IsEnabled = false;
                    }
                    break;

                default:
                    Submit_Button.IsEnabled = false;
                    break;
            }
        }
    }
}
