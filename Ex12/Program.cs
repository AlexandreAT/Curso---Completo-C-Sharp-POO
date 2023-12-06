using System;
using System.Globalization;
using Ex12.Etities;

namespace Ex12 {
    class Program{

        static void Main(string[] args){

            string path = @"C:\Users\alexa\Desktop\Cursos e derivados\Udemy\Curso - C# Completo POO\Ex12\";
            string fileName, content, name;
            int n, quantity;
            double value;
            Product product;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("=============================================");
            Console.WriteLine("EX12 - MANIPULANDO DADOS DE UM ARQUIVO");
            Console.WriteLine("=============================================");

            Console.Write("Digite o nome do arquivo com a extensão csv (ex: 'Novo arquivo.csv'): ");
            fileName = Console.ReadLine();
            Console.Write("Digite quantos produtos você deseja adicionar no arquivo: ");
            n = int.Parse(Console.ReadLine());

            try{
                using (StreamWriter sw = new StreamWriter(path + fileName)){
                    Console.WriteLine();
                    for(int i = 1; i <= n; i++){
                        Console.WriteLine($"Cadastrando o produto da linha #{i}: ");
                        Console.Write("Digite o nome do produto: ");
                        name = Console.ReadLine();
                        Console.Write("Digite o preço do produto: ");
                        value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Digite a quantidade do produto: ");
                        quantity = int.Parse(Console.ReadLine());
                        sw.WriteLine(name+", "+value.ToString("F2", CultureInfo.InvariantCulture)+", "+quantity);
                        Console.WriteLine();
                    }
                }
                using (StreamReader sr = File.OpenText(path + fileName)){
                    Console.WriteLine();
                    Console.WriteLine("Produtos do arquivo "+fileName+": ");
                    while(!sr.EndOfStream){
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                Console.WriteLine();
                string[] lines = File.ReadAllLines(path + fileName);
                string targetFolder = path+@"out";
                string targetFile = targetFolder+@"summary.csv";
                Directory.CreateDirectory(targetFolder);
                using(StreamWriter sr = new StreamWriter(targetFile)){

                    foreach (string line in lines)
                    {
                        string[] vet = line.Split(',');
                        name = vet[0];
                        value = double.Parse(vet[1], CultureInfo.InvariantCulture);
                        quantity = int.Parse(vet[2]);

                        product = new Product(name, value, quantity);
                        Console.WriteLine(name+", "+product.TotalValue().ToString("F2", CultureInfo.InvariantCulture));
                    }

                }
                Console.WriteLine();
                Console.WriteLine("Digite 'enter' para sair!");
                Console.ReadLine();

            }
            catch(IOException e){
                Console.WriteLine("Um erro ocorreu!");
                Console.WriteLine(e.Message);
            }

        }

    }

}