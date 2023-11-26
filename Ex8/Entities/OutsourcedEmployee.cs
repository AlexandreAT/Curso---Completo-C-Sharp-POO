using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex8.Entities
{
    public class OutsourcedEmployee : Employee
    {
        
        public double AdditionalCharge {get; set;}

        public OutsourcedEmployee(){
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour) {

            AdditionalCharge = additionalCharge;

        }

        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.10);

        }

        public override string ToString()
        {
            return "Funcionário: "+Name+", trabalha "+Hours+"Hrs, recebe $"
            +ValuePerHour.ToString("F2", CultureInfo.InvariantCulture)+" por hora trabalhada, pagamento total + bônus R$ "
            +Payment().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}