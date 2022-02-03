using CustomerData2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricBillAverageGUI
{
 /* Form with list box that returns inputed data from frmEnterData and will calculate inputed data---
  * and calculate number of customers, a bill based on a $0.07 charge per KWh used, long with a $12 ---
  * administrative charge. 
  * Will also calculate an average bill amount based on the amount of customers that are added to the list. 
 * Author: Dillon Crowshoe-Patterson
 * Due: July 13, 2021
 */
    public partial class frmTrackData : Form
    {
        // Customer Data list
        List<Customer> customers = new List<Customer>();//empty
                   
        public frmTrackData()
        {
            InitializeComponent();
        }
        // load form with empty fields once started. 
        private void frmTrackData_Load(object sender, EventArgs e)
        {
            txtAmountOfCust.Text = customers.Count.ToString();       
        }
        //add another Customer with Add button. 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // establishing communication with second form for inputing data. 
            frmEnterData secondForm = new frmEnterData(); //create object of the second form
            DialogResult result = secondForm.ShowDialog(); //display second form model
            if(result == DialogResult.OK)
            {
                //get customer
                Customer newCust = (Customer)secondForm.Tag;
                //add to the list
                customers.Add(newCust);
                //display
                DisplayCustomers();
            }
        }
        //displays inputed data and calculations onto the TrackData form. 
        private void DisplayCustomers()
        {
            lstCustData.Items.Clear(); //clear the list box content

            //adds amount of customers inputed and displays in textbox "Amount of Customers"
            foreach (Customer c in customers)
                lstCustData.Items.Add(c);
            txtAmountOfCust.Text = lstCustData.Items.Count.ToString();

            //calculate all KWh Used and displaying in "Total KWh Used" text box.
            decimal sum = 0;
            for (int i = 0; i < lstCustData.Items.Count; i++)
                sum += customers[i].KWhUsage;
            txtKWhTotal.Text = Convert.ToString(sum);

            //calculate average bill amount and displaying in "Average bill Amount" text box.
            decimal average = 0;
            decimal length = customers.Count;
            foreach (Customer c in customers)
            {
                average += c.CalculateCharge() / length;
                txtAverageBill.Text = average.ToString("c");//dispays in textbox "Average Bill Amount".
            }
         
        }
        //exit the application by clicking exit.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
