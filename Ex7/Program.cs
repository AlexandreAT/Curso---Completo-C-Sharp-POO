using System;
using System.Globalization;
using Ex7.Entities;
using Ex7.Entities.Enums;

namespace Ex7 {
    class Program{

        static void Main(string[] args){

            string name, email, nameItem;
            int quantityItem, n;
            double price;
            DateTime birthDate;
            OrderStatus status;
            Order order;
            OrderItem orderItem;
            Product product;
            Client client;

            Console.WriteLine("");
            Console.WriteLine("=============================================");
            Console.WriteLine("EX7 - PROCESSOS DE UM PEDIDO");
            Console.WriteLine("=============================================");

            Console.WriteLine("-----------CADASTRANDO O CLIENTE-----------");
            Console.Write("Digite o nome do cliente: ");
            name = Console.ReadLine();
            Console.Write("Digite o email do cliente: ");
            email = Console.ReadLine();
            Console.Write("Digite a data do aniverário do cliente: ");
            birthDate = DateTime.Parse(Console.ReadLine());
            client = new Client(name, email, birthDate);

            Console.WriteLine("");
            Console.WriteLine("-----------CADASTRANDO O PEDIDO------------");
            Console.Write("Digite o status do pedido (PendingPayment/Processing/Shipped/Delivered): ");
            status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("Digite quantos itens tem nesse pedido: ");
            n = int.Parse(Console.ReadLine());
            order = new Order(DateTime.Now, status, client);
            Console.WriteLine("");

            for(int i = 1; i <= n; i++){
                
                Console.WriteLine("-----------CADASTRANDO O ITEM " + i + "------------");
                Console.Write("Digite o nome do produto: ");
                nameItem = Console.ReadLine();
                Console.Write("Digite o preço do produto: ");
                price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Digite a quantidade do produto: ");
                quantityItem = int.Parse(Console.ReadLine());
                product = new Product(nameItem, price);
                orderItem = new OrderItem(quantityItem, price, product);
                Console.WriteLine();

                order.AddItem(orderItem);

            }

            Console.WriteLine();
            Console.WriteLine("RESUMO DO PEDIDO:");
            Console.WriteLine(order);

        }

    }

}