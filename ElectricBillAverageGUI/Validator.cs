using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
/* Validator Class added to generate validation that when a customer is adding data, proper fields---
 * containg the correct statistics are entered. 
 * Author: Dillon Crowshoe-Patterson
 * Due: July 13, 2021
 */

namespace ElectricBillAverageGUI
{

    /// <summary>
    /// a repository of validation methods
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// checks if textbox is not empty
        /// </summary>
        /// <param name="txtInput">textbox to validate
        /// (must have meaningful name in tag for error message</param>
        /// <returns>true is present if false is not</returns>
        public static bool IsPresent(TextBox txtInput)
        {
            bool isValid = true; //"innocent until proven guilty"
            if (txtInput.Text == "")
            {
                MessageBox.Show(txtInput.Tag + " must be provided", "Input Error");
                txtInput.Focus(); //put focus on the tectbox to guide the user
                isValid = false;
            }
            return isValid;
        }


        /// <summary>
        /// checks if textbox contains non-negative int number
        /// </summary>
        /// <param name="txtInput">textbox to validate
        /// (must have meaningful name in tag for error message</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeInt(TextBox txtInput)
        {
            bool isValid = true;
            int value;

            if (!Int32.TryParse(txtInput.Text, out value)) // if not an int
            {
                MessageBox.Show(txtInput.Tag + " should be whole number", "Input Error");
                txtInput.SelectAll();
                txtInput.Focus();
                isValid = false;
            }
            else // it is an int, but could be negative
            {
                if (value < 0)
                {
                    MessageBox.Show(txtInput.Tag + " should be a positive or zero", "Input Error");
                    txtInput.SelectAll();
                    txtInput.Focus();
                    isValid = false;
                }
            }

            return isValid;
        }
        /// <summary>
        /// checks if textbox contains non-negative double number
        /// </summary>
        /// <param name="txtInput">textbox to validate
        /// (must have meaningful name in tag for error message</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeDouble(TextBox txtInput)
        {
            bool isValid = true;
            double value;

            if (!Double.TryParse(txtInput.Text, out value)) // if not an double
            {
                MessageBox.Show(txtInput.Tag + " should be a number", "Input Error");
                txtInput.SelectAll();
                txtInput.Focus();
                isValid = false;
            }
            else // it is an double, but could be negative
            {
                if (value < 0)
                {
                    MessageBox.Show(txtInput.Tag + " should be a positive or zero", "Input Error");
                    txtInput.SelectAll();
                    txtInput.Focus();
                    isValid = false;
                }
            }

            return isValid;
        }
        /// <summary>
        /// checks if textbox contains non-negative decimal number
        /// </summary>
        /// <param name="txtInput">textbox to validate
        /// (must have meaningful name in tag for error message</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeDecimal(TextBox txtInput)
        {
            bool isValid = true;
            decimal value;

            if (!Decimal.TryParse(txtInput.Text, out value)) // if not an decimal
            {
                MessageBox.Show(txtInput.Tag + " should be a number", "Input Error");
                txtInput.SelectAll();
                txtInput.Focus();
                isValid = false;
            }
            else // it is an decimal, but could be negative
            {
                if (value < 0)
                {
                    MessageBox.Show(txtInput.Tag + " should be a positive or zero", "Input Error");
                    txtInput.SelectAll();
                    txtInput.Focus();
                    isValid = false;
                }
            }

            return isValid;
        }
    }//class
}//namespace
