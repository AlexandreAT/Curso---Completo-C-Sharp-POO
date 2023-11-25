using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Ex5.Entities
{
    public class HourContract
    {
        public DateTime Date {get; set;}
        public double ValuesPerHour {get; set;}
        public int Hours {get; set;}

        public HourContract(){
        }

        public HourContract(DateTime date, double valuesPerHour, int hours){
            Date = date;
            ValuesPerHour = valuesPerHour;
            Hours = hours;
        }

        public double TotalValue(){
            return ValuesPerHour * Hours;
        }

        public override string ToString()
        {
            return "Contrato: Data " + Date.ToString("dd/MM/yyyy") + ", valor R$" + ValuesPerHour.ToString("F2", CultureInfo.InvariantCulture) + ", horas trabalhadas " + Hours;
        }

    }
}