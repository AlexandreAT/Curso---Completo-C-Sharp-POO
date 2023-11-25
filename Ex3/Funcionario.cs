using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Ex3
{
    public class Funcionario
    {
        public int IdFuncionario { get; private set; }
        public string Nome { get; set;} 
        public double Salario { get; private set; }

        public Funcionario(int idFuncionario, string nome, double salario){
            
            IdFuncionario = idFuncionario;
            Nome = nome;
            Salario = salario;

        }

        public void AcrescentarSalario(double porcentagem){
            Salario += (Salario * porcentagem) / 100;
        }

        public override string ToString()
        {
            return "ID - "+ IdFuncionario +", Nome - " + Nome + ", Salário - R$ " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}