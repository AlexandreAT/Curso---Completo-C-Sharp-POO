using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Ex13.Entities
{
    public class Installments
    {
        public DateTime Date {get; private set;}
        public double Value {get; private set;}

        public Installments()
        {
        }

        public Installments(DateTime date, double value)
        {

            Date = date;
            Value = value;

        }

        public override string ToString()
        {
            return "Parcela: data - "+Date.ToString("dd/MM/yyyy")+", valor - $"+Value.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}