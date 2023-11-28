using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex10.Entities
{
    public class CorporateTaxpayers : TaxPayers
    {

        public double NumberOfEmployees {get; set;}

        public CorporateTaxpayers(){
        }

        public CorporateTaxpayers(string name, double annualIncome, double numberOfEmployees) : base(name, annualIncome){

            NumberOfEmployees = numberOfEmployees;

        }

        public override double CalculationOfTaxes()
        {
            if(NumberOfEmployees > 10){
                return AnnualIncome * 0.14;
            }
            else{
                return AnnualIncome * 0.16;
            }
        }
        
    }
}