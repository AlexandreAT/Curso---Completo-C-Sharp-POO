using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex10.Entities
{
    abstract public class TaxPayers
    {

        public string Name {get; set;}
        public double AnnualIncome {get; set;}

        public TaxPayers(){
        }

        public TaxPayers(string name, double annualIncome){

           Name = name;
           AnnualIncome = annualIncome;

        }

        public abstract double CalculationOfTaxes();

        public override string ToString()
        {
            return "Nome: "+Name+" - imposto $ "+CalculationOfTaxes().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}