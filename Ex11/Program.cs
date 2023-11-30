using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using Ex11.Entities;
using Ex11.Exceptions;

namespace Ex11 {
    class Program{

        static void Main(string[] args){

            int number;
            string holder;
            double balance, withdrawLimit, amount;
            char op;
            Account account;

            Console.WriteLine("");
            Console.WriteLine("=============================================");
            Console.WriteLine("EX11 - REALIZANDO DEPÓSITO E SAQUE");
            Console.WriteLine("=============================================");

            Console.Write("Digite o número da conta: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Digite o titula da conta: ");
            holder = Console.ReadLine();
            Console.Write("Digite saldo inicial da conta: ");
            balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite limite de saque da conta: ");
            withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account = new Account(number, holder, balance, withdrawLimit);
            Console.WriteLine();
            Console.WriteLine(account);
            Console.WriteLine();

            Console.Write("Deseja fazer um depósito? (S/N): ");
            op = char.Parse(Console.ReadLine());
            Console.WriteLine();

            if(op == 'S' || op == 's'){

                Console.Write("Entre com o valor de depósito: ");
                amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Deposit(amount);
                Console.WriteLine(account);

            }

            Console.Write("Entre com o valor de saque: ");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try{

                account.Withdraw(amount);
                Console.WriteLine(account);

            }
            catch(DomainException e){

                Console.WriteLine();
                Console.WriteLine("Error: "+e.Message);
                Console.WriteLine();

            }

        }

    }

}