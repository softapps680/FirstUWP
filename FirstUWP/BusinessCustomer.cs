using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUWP
{
    public class BusinessCustomer:Customer
    {   
        
        
        public decimal Discount { get; private set; } = 0.90m;
        public decimal FinalPrice { get; set; }

        public void SetDiscount(decimal value)
        {
            Discount = value;
        }
        

        //Man kan alltså inte ärva konstruktorn utan man anropar basklassens konstruktor
        public BusinessCustomer(int id, string firstName, string lastName, decimal baseprice,Ticket ticket):base(id,firstName,lastName,baseprice,ticket)
        {
            this.FinalPrice = this.CalculateDiscountPrice(baseprice); 
        }
        public BusinessCustomer()
        {

        }
        public override decimal CalculateDiscountPrice(decimal price)
        {
            return (decimal) price * Discount;
        }
    }
}
