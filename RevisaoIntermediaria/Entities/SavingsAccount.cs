using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace RevisaoIntermediaria.Entities
{
    sealed public class SavingsAccount : Account
    {
        public double InterestRate {get; set;}

        public SavingsAccount(){
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance) {

            InterestRate = interestRate;

        }

        public void UpdateBalance(){
            Balance += Balance*InterestRate;
        }

        public override void Withdraw(double Amount){
            Balance -= Amount;
        }

        public override string ToString()
        {
            return "Conta: "+Number+" - "+Holder+", R$ "+Balance.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}