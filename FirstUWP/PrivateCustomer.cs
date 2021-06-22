using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUWP
{
    public class PrivateCustomer : Customer
    {
        public decimal Discount { get; private set; } = 0.9m;
        public decimal FinalPrice { get; set; }
        public decimal Tax { get; private set; } = 1.25m;
        public PrivateCustomer(int id, string firstName, string lastName, decimal baseprice,Ticket ticket) : base(id, firstName, lastName, baseprice,ticket)
        {
            SetFinalPrice(baseprice);
        }
        public PrivateCustomer()
        {

        }
        public void SetDiscount(decimal value)
        {
            Discount = value;
        }
        public void SetTax(decimal value)
        {
            Tax = value;
        }
        //ev kundrabatt
        public override decimal CalculateDiscountPrice(decimal price)
        {
            return price * Discount;
        }

        //moms
        public  decimal PriceWithTax(decimal price)
        {
            return price * this.Tax;
        }
        public void SetFinalPrice(decimal baseprice)
        {
            var price = CalculateDiscountPrice(baseprice);
            FinalPrice = PriceWithTax(price);
        }
    }
}
