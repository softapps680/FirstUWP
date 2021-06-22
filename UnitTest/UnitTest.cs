
using System;
using FirstUWP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public BusinessCustomer _bc;
        public PrivateCustomer _pc;

        public UnitTest1()
        {
            _bc = new BusinessCustomer();
            _bc.SetDiscount(0.9m);

            _pc = new PrivateCustomer();
            _pc.SetDiscount(0.9m);
            _pc.SetTax(1.25m);
        }


      
        [DataTestMethod]
        [DataRow( 90.0, 100.0)]
        [DataRow(135.0, 150.0)]
        //Det går inte att använda datatypen decimal som testattribut 
        public void CalculateDiscountPrice_Shold_Return_Prize_Minus_Discount_Percent(double expected, double price)
        {
            
            decimal actual = _bc.CalculateDiscountPrice((decimal)price);

            Assert.AreEqual((decimal)expected, actual);

        }
       
        [DataTestMethod]
        [DataRow(90.0, 100.0)]
        [DataRow(270.0, 300.0)]
         public void CalculateCustomerDiscountPrice_Shold_Return_Prize_Minus_Discount_Percent(double expected, double price)
        {

            decimal actual = _pc.CalculateDiscountPrice((decimal)price);

            Assert.AreEqual((decimal)expected, actual);

        }
        
        [DataTestMethod]
        [DataRow(125.0, 100.0)]
        [DataRow(375.0, 300.0)]
        public void CalculateCustomerTax_Shold_Return_Prize_Plus_Tax(double expected, double price)
        {

            decimal actual = _pc.PriceWithTax((decimal)price);

            Assert.AreEqual((decimal)expected, actual);

        }
    }
}
