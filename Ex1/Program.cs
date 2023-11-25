using System;
using System.Globalization;

namespace Ex1 {
    class Program{

        static void Main(string[] args){

            int numConta, resp = 0;
            string nome;
            char opcao;
            double valor;
            Conta conta = null;

            Console.WriteLine("");
            Console.WriteLine("=============================================");
            Console.WriteLine("EX1 - CONTA BANCÁRIA");
            Console.WriteLine("=============================================");

            while(resp != 4){
                Console.WriteLine("Opções: ");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("1 - Cadastrar conta");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("3 - Sacar");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("");
                Console.Write("Digite a opção escolhida: ");
                resp = int.Parse(Console.ReadLine());

                if (resp == 1){
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Cadastrar conta");
                    Console.WriteLine("-------------------------------------------------------");
                    Console.Write("Entre com o número da conta: ");
                    numConta = int.Parse(Console.ReadLine());
                    Console.Write("Entre com o nome do titular: ");
                    nome = Console.ReadLine();
                    Console.Write("Haverá depósito inicial (S/N)? ");
                    opcao = char.Parse(Console.ReadLine());

                    if(opcao == 'S' || opcao == 's'){
                        Console.Write("Entre com o depósito inicial: ");
                        valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        conta = new Conta(numConta, nome, valor);
                        Console.WriteLine("");
                    }
                    else{
                        conta = new Conta(numConta, nome);
                        Console.WriteLine("");
                    }
                    Console.WriteLine("Dados da conta: " + conta);
                    Console.WriteLine("");
                }

                else if (resp == 2){
                    if (conta == null){
                        Console.WriteLine("Você deve cadastrar uma conta primeiro.");
                        break;
                    }
                    else{
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("Depositar");
                        Console.WriteLine("-------------------------------------------------------");
                        Console.Write("Entre com o valor a ser depositado: ");
                        valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        conta.Depositar(valor);
                        Console.WriteLine("Dados da conta: " + conta);
                        Console.WriteLine("");
                    }
                }

                else if (resp == 3){
                    if (conta == null){
                        Console.WriteLine("Você deve cadastrar uma conta primeiro.");
                        break;
                    }
                    else{
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("Sacar");
                        Console.WriteLine("-------------------------------------------------------");
                        Console.Write("Entre com o valor a ser sacado: ");
                        valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        conta.Sacar(valor);
                        Console.WriteLine("Dados da conta: " + conta);
                        Console.WriteLine("");
                    }
                }

                else if (resp == 4){
                    Console.WriteLine("");
                    Console.WriteLine("Saindo do programa");
                    Console.WriteLine("");
                    break;
                }

            }
        }
    }
}
