using System;
using System.Globalization;

namespace Ex1
{
    public class Conta
    {

        public int NumConta { get; private set;}
        public double Valor { get; private set;}
        public string Nome { get; set;}

        public Conta(int numConta, string nome){
            
            NumConta = numConta;
            Nome = nome;
            Valor = 0;

        }
        public Conta(int numConta, string nome, double valorInicial) : this(numConta, nome){
            
            Depositar(valorInicial);

        }

        public void Depositar(double valor){
            Valor += valor;
        }

        public void Sacar(double valor){
            Valor -= valor + 5;
        }

        public override string ToString()
        {
            return "Conta " + NumConta + ", titular: " + Nome + ", saldo: $" + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
        
    }
}