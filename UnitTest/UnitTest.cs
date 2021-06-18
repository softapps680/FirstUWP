
using System;
using FirstUWP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public BusinessCustomer _bc;

        public UnitTest1()
        {
            _bc = new BusinessCustomer();
            //25 procents rabatt kör vi
            _bc.SetDiscount(0.75m);
        }


        [TestMethod]

        public void CalculateDiscountPrice_Shold_Return_Prize_Minus_25_Percent()
        {
            

            var actual = _bc.CalculateDiscountPrice(100);

            Assert.AreEqual(75.0m, actual);

        }
    }
}
