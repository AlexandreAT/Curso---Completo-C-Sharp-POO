using System;
using System.Globalization;
using Ex10.Entities;

namespace Ex10 {
    class Program{

        static void Main(string[] args){

            int n, numberOfEmployees;
            string name;
            double annualIncome, healthSpending, sum = 0;
            char op;
            List<TaxPayers> taxpayers = new List<TaxPayers>();

            Console.WriteLine("");
            Console.WriteLine("=============================================");
            Console.WriteLine("EX10 - CONTRIBUENTES");
            Console.WriteLine("=============================================");

            Console.Write("Digite quantos contribuentes serão cadastrados: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++){

                Console.WriteLine();
                Console.WriteLine($"----------------CADASTRANDO O CONTRIBUENTE #{i}----------------");
                Console.Write("O cadastro é de pessoa física ou jurídica? (I/C): ");
                op = char.Parse(Console.ReadLine());
                if(op != 'i' && op != 'I' && op != 'c' && op != 'C'){
                    Console.WriteLine("Escolha inválida!");
                    Console.WriteLine();
                    i--;
                    continue;
                }
                Console.Write("Digite o nome: ");
                name = Console.ReadLine();
                Console.Write("Digite o ganho anual: ");
                annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(op == 'i' || op == 'I'){
                    Console.Write("Digite o custo com a saúde: ");
                    healthSpending = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxpayers.Add(new IndividualTaxpayers(name, annualIncome, healthSpending));
                }
                else if(op == 'c' || op == 'C'){
                    Console.Write("Digite a quantidade de funcionários da empresa: ");
                    numberOfEmployees = int.Parse(Console.ReadLine());
                    taxpayers.Add(new CorporateTaxpayers(name, annualIncome, numberOfEmployees));
                }
                Console.WriteLine("-------------------------------------------------------------");

            }

            Console.WriteLine();
            Console.WriteLine("----------------IMPOSTOS A PAGAR-----------------------------");
            foreach (TaxPayers taxpayer in taxpayers)
            {

                Console.WriteLine(taxpayer);
                sum += taxpayer.CalculationOfTaxes();
                
            }

            Console.WriteLine();
            Console.WriteLine("Impostos totais: $ "+sum.ToString("F2", CultureInfo.InvariantCulture));

        }

    }

}