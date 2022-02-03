using CustomerData2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
/* Form with allow user to input customer data and return and store information to "frmTrackData"--
  * while running the application. 
 * Author: Dillon Crowshoe-Patterson
 * Due: July 13, 2021
 */

namespace ElectricBillAverageGUI
{
 
    public partial class frmEnterData : Form
    {
        Customer newCust; // new customer
        public frmEnterData()
        {
            InitializeComponent();
        }
        //create new customer and store in Tag property
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validator function for making certain input required. Must enter forst and last names.
            if(Validator.IsPresent(txtFName) && 
                Validator.IsPresent(txtLName) &&
                //Validator function for making certain input required. Cannot enter negative KWh used. 
                Validator.IsNonNegativeDecimal(txtKWhUseEnter) &&
                //Validator function for making certain input required. Must enter KWh used.
                Validator.IsPresent(txtKWhUseEnter) &&
                //Validator function for making certain input required. Must enter an account number.
                Validator.IsPresent(txtAccountNo) &&
                //Validator function for making certain input required. Cannot be a negative number. 
                Validator.IsNonNegativeInt(txtAccountNo))
                //if valid data
            {
                
                newCust = new Customer(txtFName.Text, txtLName.Text,
                                        Convert.ToDecimal(txtKWhUseEnter.Text),
                                        Convert.ToInt32(txtAccountNo.Text));
                //store in Tag
                this.Tag = newCust;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
