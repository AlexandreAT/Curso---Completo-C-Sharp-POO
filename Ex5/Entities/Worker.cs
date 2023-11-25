using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Ex5.Entities.Enums;

namespace Ex5.Entities
{
    public class Worker
    {

        public string Name {get; set;}
        public WorkerLevel Level {get; set;}
        public double BaseSalary {get; set;}
        public Department Department {get; set;} 
        public List<HourContract> Contracts {get; set;} = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary, Department department){

            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;

        }

        public void AddContract(HourContract contract){

            Contracts.Add(contract);

        }

        public void RemoveContract(HourContract contract){

            Contracts.Remove(contract);

        }

        public double Income(int year, int month){
            double soma = BaseSalary;
            
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Month == month && contract.Date.Year == year){
                    soma += contract.TotalValue();
                }
            }

            return soma;

        }

        public override string ToString()
        {
            return "Trabalhador: " + Name + ", " + Level + ", " + BaseSalary.ToString("F2", CultureInfo.InvariantCulture) + ".";
        }

    }
}