using System;
using System.Globalization;
using Ex9.Entities;

namespace Ex9 {
    class Program{

        static void Main(string[] args){

            int n;
            char op;
            string name;
            double price, customsFee;
            DateTime manufactureDate;
            List<Product> products = new List<Product>();

            Console.WriteLine("");
            Console.WriteLine("=============================================");
            Console.WriteLine("EX9 - CADASTRANDO PRODUTOS");
            Console.WriteLine("=============================================");

            Console.Write("Digite quantos produtos serão cadastrados: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++){
                Console.WriteLine();
                Console.Write("O produto é comum, usado ou importado? (C/U/I): ");
                op = char.Parse(Console.ReadLine());
                Console.Write("Digte o nome do produto: ");
                name = Console.ReadLine();
                Console.Write("Digte o preço do produto: ");
                price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(op == 'U' || op == 'u'){
                    Console.Write("Digte a data de frabricação desse produto: ");
                    manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if(op == 'I' || op == 'i'){
                    Console.Write("Digte a taxa da alfândega: ");
                    customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else{
                    products.Add(new Product(name, price));
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("Produtos adicionados:");
            foreach (Product product in products)
            {
                
                Console.WriteLine(product.PriceTag());

            }

        }

    }

}