using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Revisao
{
    public class Produto
    {
        private int _referenciaProduto = 0;
        public string Nome;
        public double Preco;
        public int QtdEstoque;
        public int IdProduto { get; private set; }

        public Produto(string nome, double preco){
            Nome = nome;
            Preco = preco;
            QtdEstoque = 1;
        }

        public Produto(string nome, double preco, int qtdEstoque){
            Nome = nome;
            Preco = preco;
            QtdEstoque = qtdEstoque;
            IdProduto++;
        }

        public int ReferenciaProduto{
            get { return _referenciaProduto; }
            set {
                if(value != 0){
                    _referenciaProduto = value;
                }
            }
        }

        public double ValorTotalEmEstoque(){
            return Preco * QtdEstoque;
        }

        public void AdicionarProdutos(int quantidade){
            QtdEstoque += quantidade;
        }

        public void RetirarProdutos(int quantidade){
            QtdEstoque -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", "+ QtdEstoque + " unidades, total: " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}