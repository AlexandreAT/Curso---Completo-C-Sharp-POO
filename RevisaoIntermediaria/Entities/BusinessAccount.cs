using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace RevisaoIntermediaria.Entities
{
    public class BusinessAccount : Account
    {

        public double LoanLimit {get; set;}

        public BusinessAccount(){
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) {

            LoanLimit = loanLimit;

        }

        public void Loan(double amount){
            if(amount <= LoanLimit){
                Balance += amount;
            }
        }

        public sealed override void Withdraw(double Amount)
        {
            base.Withdraw(Amount);
            Balance -= 3;
        }

        public override string ToString()
        {
            return "Conta: "+Number+" - "+Holder+", R$ "+Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
        
    }
}