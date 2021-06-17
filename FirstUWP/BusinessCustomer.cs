using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUWP
{
    public class BusinessCustomer:Customer
    {
        //Man kan alltså inte ärva konstruktorn utan man anropar basklassens konstruktor
        public BusinessCustomer(int id, string firstName, string lastName, Ticket ticket):base(id,firstName,lastName,ticket)
        {
           
        }
        public override decimal CalculateDiscountPrice(decimal price)
        {
            return price * 0.25m;
        }
    }
}
