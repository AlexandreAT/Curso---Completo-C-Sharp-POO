using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex10.Entities
{
    public class IndividualTaxpayers : TaxPayers
    {

        public double HealthSpending {get; set;}

        public IndividualTaxpayers(){
        }

        public IndividualTaxpayers(string name, double annualIncome, double healthSpending) : base(name, annualIncome){

            HealthSpending = healthSpending;

        }

        public override double CalculationOfTaxes()
        {
            if(AnnualIncome < 20000.00){
                return (AnnualIncome * 0.15) - (HealthSpending * 0.50);
            }
            else{
                return (AnnualIncome * 0.25) - (HealthSpending * 0.50);
            }
        }

    }
}