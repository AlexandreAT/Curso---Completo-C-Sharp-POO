using System;
using System.Globalization;
using RevisaoIntermediaria.Entities;
using RevisaoIntermediaria.Entities.Enums;

namespace RevisaoIntermediaria {
    class Program{

        static void Main(string[] args){

            int resp;

            Console.WriteLine("");
            Console.WriteLine("=============================================");
            Console.WriteLine("REVISÃO INTERMEDIÁRIA");
            Console.WriteLine("=============================================");

            do
            {
                Console.WriteLine("Opções: ");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("1 - Enumeração");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("2 - Herença");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("3 - Sair");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("");
                Console.Write("Digite a opção escolhida: ");
                resp = int.Parse(Console.ReadLine());

                switch(resp){
                    case 1:
                        Enumeração();
                    break;
                    case 2:
                        Herenca();
                    break;
                }

            } while (resp != 3);
        }

        static void Enumeração(){
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Enumeração");
            Console.WriteLine("-------------------------------------------------------");

            Order order = new Order{Id = 1020, Moment = DateTime.Now, Status = OrderStatus.PendingPayment};

            Console.WriteLine("");
            Console.WriteLine(order);
            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); 

            Console.WriteLine("");
            Console.WriteLine(txt);
            Console.WriteLine(os);

            Console.WriteLine("");
            Console.WriteLine("Clique enter para voltar ao menu");
            Console.ReadLine();
        }

        static void Herenca(){

            int op = 0, number;
            string holder;
            double balance, loanLimit, value, interest;
            Account account;
            BusinessAccount businessAccount;
            SavingsAccount savingsAccount;

            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Herença");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
            
            Console.Write("Digite qual tipo de conta você deseja cadastrar (1 - Conta Normal/2 - Conta Empresarial/3 - Conta Poupança): ");
            op = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digte o número da conta: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Digte o nome do titular da conta: ");
            holder = Console.ReadLine();
            Console.Write("Digte o saldo inicial da conta: ");
            balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            if(op == 1){

                account = new Account(number, holder, balance);
                
                do
                {

                    Console.WriteLine("0 - Sair ");
                    Console.WriteLine("1 - Adicionar saldo");
                    Console.WriteLine("2 - Remover saldo (-$5 da taxa)");
                    Console.Write("Digite a opção escolhida: ");
                    op = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if(op == 1){
                        Console.Write("Digite o valor a ser adicionado: ");
                        value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        account.Deposit(value);
                    }
                    else if(op == 2){
                        Console.Write("Digite o valor a ser removido: ");
                        value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        account.Withdraw(value);
                    }

                    Console.WriteLine(account);
                    Console.WriteLine();

                } while (op != 0);

            }
            else if(op == 2){

                Console.Write("Digte o limite de empréstimo inicial: ");
                loanLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                businessAccount = new BusinessAccount(number, holder, balance, loanLimit);
                Console.WriteLine();

                do
                {
                    Console.WriteLine("0 - Sair ");
                    Console.WriteLine("1 - Adicionar saldo");
                    Console.WriteLine("2 - Remover saldo (-$8 da taxa)");
                    Console.WriteLine("3 - Pegar empréstimo");
                    Console.Write("Digite a opção escolhida: ");
                    op = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if(op == 1){
                        Console.Write("Digite o valor a ser adicionado: ");
                        value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        businessAccount.Deposit(value);
                    }
                    else if(op == 2){
                        Console.Write("Digite o valor a ser removido: ");
                        value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        businessAccount.Withdraw(value);
                    }
                    else if(op == 3){
                        Console.Write("Digite o valor que deseja pegar: ");
                        value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        businessAccount.Loan(value);
                    }

                    Console.WriteLine(businessAccount);
                    Console.WriteLine();

                } while (op != 0);

            }

            else if(op == 3){

                Console.Write("Digte o valor do juros (ex: 0.10): ");
                interest = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                savingsAccount = new SavingsAccount(number, holder, balance, interest);
                Console.WriteLine();

                do
                {
                    Console.WriteLine("0 - Sair ");
                    Console.WriteLine("1 - Adicionar saldo");
                    Console.WriteLine("2 - Remover saldo");
                    Console.WriteLine("3 - Atualizar/Verificar o valor da poupança");
                    Console.Write("Digite a opção escolhida: ");
                    op = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if(op == 1){
                        Console.Write("Digite o valor a ser adicionado: ");
                        value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        savingsAccount.Deposit(value);
                    }
                    else if(op == 2){
                        Console.Write("Digite o valor a ser removido: ");
                        value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        savingsAccount.Withdraw(value);
                    }
                    else if(op == 3){
                        savingsAccount.UpdateBalance();
                        Console.WriteLine("Valor da poupança: "+savingsAccount.Balance.ToString("F2", CultureInfo.InvariantCulture));
                    }

                    Console.WriteLine(savingsAccount);
                    Console.WriteLine();

                } while (op != 0);

            }

            else{

                Console.WriteLine();
                Console.WriteLine("Opção inválida!");
            }

            Console.WriteLine("");
            Console.WriteLine("Clique enter para voltar ao menu");
            Console.ReadLine();

        }

    }
}