using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUWP
{
    public class Ticket
    {
        public int Id { get; set; }

        public Status Status { get; set; }
       
        public Ticket(int id, Status s)
        {
           this.Id = id;
           this.Status = s;
        }
    }
}
