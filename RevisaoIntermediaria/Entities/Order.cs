using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RevisaoIntermediaria.Entities.Enums;

namespace RevisaoIntermediaria.Entities
{
    public class Order
    {
        public int Id {get; set;}
        public DateTime Moment {get; set;}
        public OrderStatus Status {get; set;}

        public override string ToString()
        {
            return Id + ", " + Moment + ", " + Status + ".";
        }
    }
}