using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex13.Services
{
    public interface IPaymentService
    {
        double InstallmentAmount(int totalInstallments, double basicValue, int currentInstallment);
        
    }
}