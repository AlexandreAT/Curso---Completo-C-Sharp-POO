using System;
using System.Data;
using System.Globalization;
using Ex13.Entities;
using Ex13.Services;

namespace Ex13 {
    class Program{

        static void Main(string[] args){

            int contractNumber, totalInstallments;
            DateTime date;
            double totalValue;
            Contract contract;
            GenerateInstallments generateInstallments;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("=============================================");
            Console.WriteLine("EX13 - PROCESSAMENTO DE CONTRATO");
            Console.WriteLine("=============================================");

            Console.Write("Digite o número do contrato: ");
            contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Digite a data do contrato (dd/MM/yyyy): ");
            date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Digite o valor total do contrato: ");
            totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite quantas parcelas o contrato tera: ");
            totalInstallments = int.Parse(Console.ReadLine());
            contract = new Contract(contractNumber, date, totalValue);
            generateInstallments = new GenerateInstallments(new PaypalService());
            generateInstallments.GeneratingInstallment(contract, totalInstallments);

            Console.WriteLine();
            Console.WriteLine(contract);

        }

    }

}