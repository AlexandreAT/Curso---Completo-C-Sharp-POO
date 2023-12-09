using System;
using System.Collections.Generic;
using Ex13.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Ex13.Services
{
    public class GenerateInstallments
    {
        private IPaymentService _paymentService;
        
        public GenerateInstallments(IPaymentService paymentService){
            
            _paymentService = paymentService;

        }

        public void GeneratingInstallment(Contract contract, int totalInstallments){

            DateTime date = contract.Date;
            double basicValue = contract.Value / totalInstallments;

            for(int i = 1; i <= totalInstallments; i ++){

                date = date.AddMonths(1);
                contract.AddInstallment(new Installments(date, _paymentService.InstallmentAmount(totalInstallments, basicValue, i)));

            }

        }
        
    }
}