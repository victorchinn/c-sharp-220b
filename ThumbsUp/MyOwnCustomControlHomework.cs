﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace ThumbsUp
{

    public class MyOwnCustomControlHomework : TextBox
    {

        protected override void OnPreviewTextInput(TextCompositionEventArgs e)
        {
            e.Handled = !AreAllValidNumericChars(e.Text);
            base.OnPreviewTextInput(e);
        }

        private bool AreAllValidNumericChars(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsNumber(c)) return false;
            }

            if (this.Text.Length >=3)
            {
                return false;
            }
            return true;
        }
    }
}
