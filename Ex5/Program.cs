using System;
using System.Diagnostics;
using System.Globalization;
using Ex5.Entities;
using Ex5.Entities.Enums;

namespace Ex5 {
    class Program{

        static void Main(string[] args){

            string name, nameDepartment;
            double baseSalary, valuesPerHour;
            int n, hours;
            DateTime date;
            WorkerLevel level;
            Worker worker;
            Department department;
            HourContract contract;

            Console.WriteLine("");
            Console.Write("Digite o nome do departamento: ");
            nameDepartment = Console.ReadLine();
            department = new Department(nameDepartment);
            Console.WriteLine("");

            Console.WriteLine("Entre com os dados do trabalhador: ");
            Console.Write("Nome: ");
            name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário base: ");
            baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");

            worker = new Worker(name, level, baseSalary, department);

            Console.Write("Digite quantos contratos esse trabalhador tem: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            for(int i = 1; i <= n; i++){

                Console.WriteLine("Cadastrando o "+ i +" contrato");
                Console.Write("Data (DD/MM/AAAA): ");
                date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora trabalhada: ");
                valuesPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Horas trabalhadas: ");
                hours = int.Parse(Console.ReadLine());
                contract = new HourContract(date, valuesPerHour, hours);
                worker.AddContract(contract);

            }

            Console.WriteLine("");
            Console.Write("Digite o mes e ano para calular os ganhos do trabalhador naquela data (MM/AAAA): ");
            // date = DateTime.Parse(Console.ReadLine());
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            worker.Income(year, month);

            // for(int i = 0; i < n; i++){
            //     if (date.Month == contract[i].Date.Month && date.Year == contract[i].Date.Year){
            //         soma += contract[i].TotalValue();
            //     }
            // }
            // soma += worker.BaseSalary;

            Console.WriteLine("");
            Console.WriteLine("Nome: " + worker.Name);
            Console.WriteLine("Departamento: " + worker.Department.Name);
            // foreach (HourContract item in contract)
            // {
            //     Console.WriteLine(item);
            // }
            Console.WriteLine("Valor total no mes escolhido: " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

        }

    }

}