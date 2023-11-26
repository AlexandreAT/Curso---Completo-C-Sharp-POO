using System;
using System.Data;
using System.Globalization;
using Ex8.Entities;

namespace Ex8 {
    class Program{

        static void Main(string[] args){

            int n, hours;
            string name;
            char resp;
            double valuePerHour, additionalCharge;
            List <Employee> employees = new List<Employee>();

            Console.WriteLine("");
            Console.WriteLine("=============================================");
            Console.WriteLine("EX8 - CADASTRANDO FUNCIONÁRIOS DE UMA EMPRESA");
            Console.WriteLine("=============================================");

            Console.Write("Digite quantos funcionários serão cadastrados: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++){
                Console.WriteLine();
                Console.WriteLine("-----------CADASTRANDO O FUNCIONARIO "+i+"-----------");
                Console.Write("O funcionário é tercerizado? (S/N): ");
                resp = char.Parse(Console.ReadLine());
                Console.Write("Digite o nome do funcionário: ");
                name = Console.ReadLine();
                Console.Write("Digite ar horas trabalhadas pelo funcionário: ");
                hours = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor ganho por hora trabalhada do funcionário: ");
                valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(resp == 'S' || resp == 's'){
                    Console.Write("Digite o valor da despesa adicional do funcionário tercerizado: ");
                    additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else if(resp == 'N' || resp == 'n'){
                    employees.Add(new Employee(name, hours, valuePerHour));
                }

            }

            Console.WriteLine();
            Console.WriteLine("Funcionários: ");
            foreach (Employee employeeIndex in employees)
            {
                
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine(employeeIndex);
                
            }
            Console.WriteLine("-----------------------------------------------------");

        }

    }

}