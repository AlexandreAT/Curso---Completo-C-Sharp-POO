using System;
using System.Globalization;
using System.Reflection.Metadata;

namespace Ex4 {
    class Program{

        static void Main(string[] args){

            int linhas, colunas, count = 0, numero;
            int[,] matriz;
            string[] vet;

            Console.WriteLine("");
            Console.WriteLine("=============================================");
            Console.WriteLine("EX4 - BUSCANDO O NÚMERO DA MATRIZ");
            Console.WriteLine("=============================================");

            Console.Write("Digite quantas linhas a matriz terá: ");
            linhas = int.Parse(Console.ReadLine());
            Console.Write("Digite quantas colunas a matriz terá: ");
            colunas = int.Parse(Console.ReadLine()); 
            matriz = new int[linhas,colunas];

            Console.WriteLine("");
            for(int i = 0; i < linhas; i++){
                Console.Write("Digite os valores correspondentes a linha " + i + " separando por espaço: ");
                vet = Console.ReadLine().Split(" ");
                for(int j = 0; j < colunas; j++){
                    matriz[i,j] = int.Parse(vet[j]);
                }
            }

            for(int i = 0; i < linhas; i++){
                Console.Write("Linha "+ i +": ");
                for(int j = 0; j < colunas; j++){
                    
                    Console.Write(""+ matriz[i,j] + " | ");

                }
                Console.WriteLine("");
            }
            Console.Write("Coluna   ");
                while(count < colunas){
                Console.Write(""+ count +" | ");
                count++;
            }
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Digite o número que deseja buscar na matriz: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for(int i = 0; i < linhas; i++){
                for(int j = 0; j < colunas; j++){

                    if(matriz[i,j] == numero){

                        Console.WriteLine("Posição do número ["+i+", "+j+"]");

                        if(j > 0){
                            Console.WriteLine("O número a esquerda é: " + matriz[i,j-1]);
                        }

                        if(i > 0){
                            Console.WriteLine("O número a acima é: " + matriz[i-1,j]);
                        }

                        if(j < colunas -1){
                            Console.WriteLine("O número a direita é: " + matriz[i,j+1]);
                        }

                        if(i < linhas -1){
                            Console.WriteLine("O número a abaixo é: " + matriz[i+1,j]);
                        }
                        Console.WriteLine("");

                    }

                }
            }

        }

    }

}