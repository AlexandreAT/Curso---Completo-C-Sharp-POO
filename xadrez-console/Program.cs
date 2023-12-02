using System;
using System.Diagnostics;
using System.Globalization;
using xadrez;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console {
    class Program{

        static void Main(string[] args){

            try{

                PartidaDeXadrez partida = new PartidaDeXadrez();

                while(!partida.terminada){

                    Console.Clear();
                    Tela.imprimierTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Digite a posição de origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Digite a posição de destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executarMovimento(origem, destino);

                }

                

            }
            catch(TabuleiroException e){
                Console.WriteLine(e.Message);
            }
            
        }

    }

}