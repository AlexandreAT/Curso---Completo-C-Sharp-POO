using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ex13.Services;
using System.Text;
using System.Globalization;

namespace Ex13.Entities
{
    public class Contract
    {
       

        public int ContractNumber {get; set;}
        public DateTime Date {get; set;}
        public double Value {get; set;}
        public List<Installments> installment;

        public Contract(int contractNumber, DateTime date, double value)
        {

            ContractNumber = contractNumber;
            Date = date;
            Value = value;
            installment = new List<Installments>();

        }

        public void AddInstallment(Installments newInstallment){
            installment.Add(newInstallment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Installments installments in installment)
            {
                sb.AppendLine(installments.ToString());
            }
            return sb.ToString();
        }

    }
}