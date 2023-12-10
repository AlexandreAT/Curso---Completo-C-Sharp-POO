using System;
using System.Globalization;

namespace Ex15 {
    class Program{

        static void Main(string[] args){

            string path = @"C:\Users\alexa\Desktop\Cursos e derivados\Udemy\Curso - C# Completo POO\Ex15\";
            string fileName, candidateName;
            int votes;
            Dictionary<string, int> candidates = new Dictionary<string, int>();

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("=============================================");
            Console.WriteLine("EX14 - CALCULANDO OS VOTOS EM URNAS DIFERENTES");
            Console.WriteLine("=============================================");

            Console.Write("Digite o nome do arquivo que contem os votos (ex: Votes.txt): ");
            fileName = Console.ReadLine();
            path += @fileName;

            using(StreamReader sr = new StreamReader(path)){
                
                while(!sr.EndOfStream){
                    string[] vect = sr.ReadLine().Split(',');
                    candidateName = vect[0];
                    votes = int.Parse(vect[1]);
                    if(candidates.ContainsKey(candidateName)){
                        candidates[candidateName] += votes;
                    }
                    else{
                        candidates.Add(candidateName, votes);
                    }
                }
            }
            Console.WriteLine();
            foreach (KeyValuePair<string, int> candidate in candidates)
            {

                Console.WriteLine(candidate.Key+": "+candidate.Value);
                
            }
            Console.WriteLine("");
            Console.WriteLine("Clique enter para voltar ao menu");
            Console.ReadLine();

        }

    }

}