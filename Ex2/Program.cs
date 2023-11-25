using System;
using System.Globalization;
using System.Net;

namespace Ex2 {
    class Program{

        static void Main(string[] args){
            
            int n, numQuarto;
            string nome, email;
            Quarto[] vetQuarto;

            Console.WriteLine("");
            Console.WriteLine("=============================================");
            Console.WriteLine("EX2 - ALUGAR QUARTO");
            Console.WriteLine("=============================================");

            Console.Write("Digite quantos estudantes vão alugar um quarto: ");
            n = int.Parse(Console.ReadLine());
            vetQuarto = new Quarto[9];
            Console.WriteLine("");

            for(int i = 0; i < n; i++){

                Console.Write("Digite o nome do estudante da posição "+ i +": ");
                nome = Console.ReadLine();
                Console.Write("Digite o email do estudante da posição "+ i +": ");
                email = Console.ReadLine();
                Console.Write("Digite o quarto escolhido pelo estudante da posição "+ i +": ");
                numQuarto = int.Parse(Console.ReadLine());

                for(int y = 0; y < 9; y++){
                    if(y == numQuarto && vetQuarto[y] == null){
                        vetQuarto[y] = new Quarto(nome, email, numQuarto);
                        Console.WriteLine("Quarto "+ y +" ocupado por - " + vetQuarto[y]);
                        Console.WriteLine("");
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Quartos:");
            for(int i = 0; i < 9; i++){

                if(vetQuarto[i] != null){
                    Console.WriteLine("Quarto "+ i +" ocupado por - " + vetQuarto[i]);
                }

            }
            Console.WriteLine("");
        }

    }

}