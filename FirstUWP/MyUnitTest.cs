using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FirstUWP
{
    [TestClass]
    public class MyUnitTest
    {
        public BusinessCustomer _bc;

        public MyUnitTest()
        {
            _bc = new BusinessCustomer();
            //25 procents rabatt kör vi
            _bc.SetDiscount(0.75m);
        }

        /*    [Theory]
            [InlineData(75.0,100.0)]
          //  [InlineData(299.25, 399.0)]
          //  [InlineData(749.25, 999.0)]
            public void CalculateDiscountPrice_Shold_Return_Prize_Minus_25_Percent( decimal expected,decimal pricebefore)
            {

                _bc.SetDiscount(0.75m);

                var actual = _bc.CalculateDiscountPrice(pricebefore);

                Assert.AreEqual(expected, actual);

            }*/

        [Fact]
        public void CalculateDiscountPrice_Shold_Return_Prize_Minus_25_Percent()
        {
            _bc.SetDiscount(0.75m);

            var actual = _bc.CalculateDiscountPrice(100);

            Assert.AreEqual(75.0, actual);

        }



    }
}
}
