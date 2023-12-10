using System;
using System.Globalization;

namespace Ex14 {
    class Program{

        static void Main(string[] args){

            int n, cod;
            HashSet<int> students = new HashSet<int>();

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("=============================================");
            Console.WriteLine("EX14 - BUSCANDO O TOTAL DE ALUNOS EM UM CURSO");
            Console.WriteLine("=============================================");

            Console.Write("Digite quantos alunos tem no curso A: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++){
                Console.Write($"Digite o código do aluno {i}: ");
                students.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine();

            Console.Write("Digite quantos alunos tem no curso B: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++){
                Console.Write($"Digite o código do aluno {i}: ");
                students.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine();

            Console.Write("Digite quantos alunos tem no curso C: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++){
                Console.Write($"Digite o código do aluno {i}: ");
                students.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine();

            Console.WriteLine("Total de estudantes: "+students.Count);
            Console.WriteLine("");
            Console.WriteLine("Clique enter para voltar ao menu");
            Console.ReadLine();

        }

    }

}