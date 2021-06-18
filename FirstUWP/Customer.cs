using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUWP
{
    public abstract class  Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Ticket Ticket { get; set; }

        public Customer()
        {
        }
        //Knyter ihop objekten med konstruktorn
        public Customer(int id, string firstName,string lastName, Ticket ticket)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Ticket = ticket;
        }

        //Klassen är abstrakt för vi vill inte ha objekt av den den är en mall för våra kunder finns ingen baskund
        //de är antingen eller
        //de måste implementera denna för att får rätt rabatt
        public abstract decimal CalculateDiscountPrice(decimal price);
       

    }
}
