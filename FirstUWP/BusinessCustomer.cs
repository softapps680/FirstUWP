using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUWP
{
    public class BusinessCustomer:Customer
    {   
        public BusinessCustomer()
        {
        }
        public decimal Discount { get; private set; } = 0;
        
        public void SetDiscount(decimal value)
        {
            Discount = value;
        }
        

        //Man kan alltså inte ärva konstruktorn utan man anropar basklassens konstruktor
        public BusinessCustomer(int id, string firstName, string lastName, Ticket ticket):base(id,firstName,lastName,ticket)
        {
           
        }
        public override decimal CalculateDiscountPrice(decimal price)
        {
            return price * Discount;
        }
    }
}
