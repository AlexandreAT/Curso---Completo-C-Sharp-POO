using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Ex8.Entities
{
    public class Employee
    {
        
        public string Name {get; set;}
        public int Hours {get; set;}
        public double ValuePerHour {get; set;}

        public Employee(){
        }

        public Employee(string name, int hours, double valuePerHour){

            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;

        }

        public virtual double Payment(){
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            return "Funcionário: "+Name+", trabalha "+Hours+"Hrs, recebe $"
            +ValuePerHour.ToString("F2", CultureInfo.InvariantCulture)+" por hora trabalhada, pagamento total R$ "
            +Payment().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}