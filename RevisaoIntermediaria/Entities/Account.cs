using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace RevisaoIntermediaria.Entities
{
    public class Account
    {

        public int Number {get; private set;}
        public string Holder {get; private set;}
        public double Balance {get; protected set;}

        public Account(){
        }

        public Account(int number, string holder, double balance){

            Number = number;
            Holder = holder;
            Balance = balance;

        }

        public virtual void Withdraw(double Amount){
            Balance -= Amount + 5;
        }

        public void Deposit(double Amount){
            Balance += Amount;
        }

        public override string ToString()
        {
            return "Conta: "+Number+" - "+Holder+", R$ "+Balance.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}