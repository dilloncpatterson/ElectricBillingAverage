using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData2;
using System;
using System.Collections.Generic;
using System.Text;

/* Test method that will test the "CalculateCharge" method inside of CustomerData2
 * 1. Test for positive KWh amount is entered.
 * 2. Test for KWh amount entered is non-negative amount.
 * 3. Test for KWh amount entered is not zero. 
 * Author: Dillon Crowshoe-Patterson
 * Due: July 13, 2021
 */

namespace CustomerData2.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void CalculateChargeTestPositiveAmount()
        {
            //arrange 
            Customer kwh = new Customer(0);
            decimal amountKWh = 150;
            decimal expectedCharge = 22.50m;
            decimal actualCharge;

            //act
            kwh.CalculateCharge();
            actualCharge = 22.50m;

            //assert
            Assert.AreEqual(expectedCharge, actualCharge);         
        }
        [TestMethod()]
        public void CalculateChargeTestNegetiveAmount()
        {
            //arrange 
            Customer kwh = new Customer(0);
            decimal amountKWh = -150;
            decimal expectedCharge = 0m;
            decimal actualCharge;

            //act
            kwh.CalculateCharge();
            actualCharge = 0m;

            //assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }
        [TestMethod()]
        public void CalculateChargeTestZeroAmount()
        {
            //arrange 
            Customer kwh = new Customer(0);
            decimal amountKWh = 0;
            decimal expectedCharge = 0m;
            decimal actualCharge;

            //act
            kwh.CalculateCharge();
            actualCharge = 0m;

            //assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }
    }
}