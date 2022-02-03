using System;
using System.Collections.Generic;
using System.Text;
/* GUI for Calculating average amount of electricity bill based on customer data.  
 * Each bill has an administrative charge of $12 and a $0.07 charge per KWh used.
 * GUI will calculate Customer's bill amount and return an average bill amount in frmTrackData
 * Author: Dillon Crowshoe-Patterson
 * Due: July 13, 2021
 */
namespace CustomerData2
{
    public class Customer
    {
        //auto-incremented accountNo starting at 100,000. 
        static private int nextAccountNo = 100000;
        //private data 
        private string firstName;
        private string lastName;
        private decimal kwhUsed;
        private int accountNo;
        const decimal ADMIN_CHARGE = 12.00m;
        const decimal RATE = 0.07m;
        

        //read -only public properties.
        public decimal bill;
        private int v;//created for testing purposes

        public string FirstName { get; set; } //auto implemented property

        public string LastName { get; set; } // auto implemented property

        public decimal KWhUsage
        {
            get {return kwhUsed; }
            set
            {
                if (value < 0) value = -value; // to make it positve
                KWhUsage = value;
            }
        }
        public int AccountNo
        {
            get { return accountNo; }
            set
            {
                if (value < 0) value = -value; //to make it positive
                accountNo = value;
            }
        }

        //constuctors
        public Customer(string f, string l, decimal k, int a)
        {
            firstName = f;
            lastName = l;
            kwhUsed = k;
            accountNo = a;         
            nextAccountNo++;
            accountNo = nextAccountNo;

        }

        public Customer(int v)// public int created for testing purposes
        {
            this.v = v;
        }

        //method created to calculate charge based on KWh entered and adding $12.00 admininstrative charge. 
        public decimal CalculateCharge()
        {
            return ADMIN_CHARGE + (kwhUsed * RATE);
        }
        // string data to be displayed in the list box on frmTrackData once it has run. 
        public override string ToString() => firstName + " " + lastName + "- " + "KWh Used: " + kwhUsed + "- "
            + "Amount Due: " + CalculateCharge().ToString("c") + "- " + "AccountNo: " + AccountNo.ToString();

        
    }
}
