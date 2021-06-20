using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUWP
{
    public class PrivateCustomer : Customer
    {
        public decimal Discount { get; private set; } = 0;
        public decimal FinalPrice { get; set; }
        public decimal Tax { get; private set; } = 1.25m;
        public PrivateCustomer(int id, string firstName, string lastName, decimal baseprice,Ticket ticket) : base(id, firstName, lastName, baseprice,ticket)
        {
            this.FinalPrice = this.PriceWithTax(baseprice);
        }
       
        //ev kundrabatt
        public override decimal CalculateDiscountPrice(decimal price)
        {
            throw new NotImplementedException();
        }

        //moms
        public  decimal PriceWithTax(decimal price)
        {
            return price * this.Tax;
        }
    }
}
