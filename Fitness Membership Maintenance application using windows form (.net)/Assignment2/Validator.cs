﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    class Validator
    {
        private static string title = "Entry Error";

 // get and set for title.
    public static string Title
        {
            get
            {
                return title;
            }
            set
            {   
                title = value;
            }
       }

   // method to check if the value is enter or not in textbox.
    public static bool IsPresent(TextBox textBox)
        {
             if (textBox.Text == "")
                {
                    MessageBox.Show(textBox.Tag + " is a required field.", Title);
                    textBox.Focus();
                    return false;
                }
            return true;
         }

    // method to check whether the input is in proper decimal format.
    public static bool IsDecimal(TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
            return true;
            }
            else
            {
            MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
            textBox.Focus();
            return false;
            }
        }

    //method to check integer type.
        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
            return true;
            }
            else
            {
            MessageBox.Show(textBox.Tag + " must be an integer.", Title);
            textBox.Focus();
            return false;
            }
        }

    // method to check the enter values are within the ranges. 
        public static bool IsWithinRange(TextBox textBox, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
            MessageBox.Show(textBox.Tag + " must be between " + min
            + " and " + max + ".", Title);
            textBox.Focus();
            return false;
            }
            return true;
        }

    // method to check if the email address is in correct format.
        public static bool IsValidEmail(TextBox textBox)
        {
            if (textBox.Text.IndexOf("@") == -1 ||
            textBox.Text.IndexOf(".") == -1)
            {
            MessageBox.Show(textBox.Tag + " must be a valid email address.",
            Title);
            textBox.Focus();
            return false;
            }
            else
            {
            return true;
            }
        }

    }
}
