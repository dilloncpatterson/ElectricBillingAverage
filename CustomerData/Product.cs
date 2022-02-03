using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerData
{
    /// <summary>
    /// defines class type for a single product
    /// </summary>
    public class Customer 
    {
        //private data 
        private string firstName;
        private string lastName;
        private decimal kwhUsed;
        private decimal billAmount;
        private int accountNo;
    
        //public properties- provide controlled access to private data
        public string FirstName { get; set; }// outer implimented property
                                             //compiler create unamed data behind this property
        public string LastName { get; set; }
        public decimal KwhUsed { get; set; }
        public decimal BillAmount { get; set; }
        public int AccountNo { get; set; }
        
       
        //constuctor
        public Customer() { }// default constuctor
                   
        public Customer(string f, string l, decimal k, decimal b, int a)
        {
             firstName = f;
             lastName = l;
             kwhUsed = k;
             billAmount = b;
            accountNo = a;
        }

        //public methods
        //redefine (overide) ToString() method from object type
        public override string ToString()
        {
            return firstName + ", " + lastName + ", " + kwhUsed.ToString("c")
                + ", " + billAmount.ToString("c") + ", " + accountNo.ToString("c");
        }
        //public decimal InventoryValue()//Averagebill?
        //{
        //    //return price * quantity;
        //}
    }
}
