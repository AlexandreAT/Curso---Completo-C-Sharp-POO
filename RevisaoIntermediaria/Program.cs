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
                Console.WriteLine("2 - Sair");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("");
                Console.Write("Digite a opção escolhida: ");
                resp = int.Parse(Console.ReadLine());

                switch(resp){
                    case 1:
                        Enumeração();
                    break;
                }

            } while (resp != 2);
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

    }
}