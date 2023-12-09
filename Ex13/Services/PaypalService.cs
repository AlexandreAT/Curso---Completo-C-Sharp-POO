using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex13.Services
{
    public class PaypalService : IPaymentService
    {

        public double InstallmentAmount(int totalInstallments, double basicValue, int currentInstallment){
            
            double interestRate = basicValue + (basicValue * (0.01 * currentInstallment));
            return interestRate + (interestRate * 0.02);

        }
        
    }
}