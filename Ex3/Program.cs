using System;
using System.Globalization;

namespace Ex3 {
    class Program{

        static void Main(string[] args){

            int n, id, idPorcentagem;
            string nome;
            double salario, porcentagem;
            List<Funcionario> funcionario = new List<Funcionario>();

            Console.WriteLine("");
            Console.WriteLine("=============================================");
            Console.WriteLine("EX3- INSERIR FUNCIONARIOS");
            Console.WriteLine("=============================================");

            Console.Write("Digite quantos funcionarios vão ser inseridos: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for(int i = 0; i < n; i++){      
                Console.WriteLine("Inserindo o funcionario da posição " + i + ": ");
                Console.Write("Digite o ID: ");
                id = int.Parse(Console.ReadLine());

                if(funcionario.Exists(x => x.IdFuncionario == id)){
                    Console.WriteLine("");
                    Console.WriteLine("O ID já existe! Cadastre outro ID.");
                    Console.WriteLine("");
                    i--;
                    continue;
                }

                Console.Write("Digite o nome: ");
                nome = Console.ReadLine();
                Console.Write("Digite o salário: ");
                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("");

                funcionario.Add(new Funcionario(id, nome, salario));
            }

            foreach(Funcionario obj in funcionario){
                Console.WriteLine("Funcionário: "+ obj);
            }

            Console.WriteLine("");
            Console.WriteLine("Adicionando uma porcentagem no salário: ");
            Console.Write("Digite o ID do funcionário que ganhará uma porcentagem: ");
            idPorcentagem = int.Parse(Console.ReadLine());

            Funcionario funcionarioEncontrado = funcionario.Find(x => x.IdFuncionario == idPorcentagem);

            if(funcionarioEncontrado != null){

                Console.Write("Digite a porcentagem que será adicionada ao salário: ");
                porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionarioEncontrado.AcrescentarSalario(porcentagem);

            }
            else{
                Console.WriteLine("O ID não existe!");
            }

            Console.WriteLine("");
            Console.WriteLine("Lista atualizada: ");
            foreach(Funcionario obj in funcionario){
                Console.WriteLine("Funcionário: "+ obj);
            }

        }
    }
}