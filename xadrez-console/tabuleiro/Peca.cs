using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace xadrez_console.tabuleiro
{
    public class Peca
    {

        public Posicao posicao {get; set;}
        public Cor cor {get; protected set;}
        public int qteMovimento {get; set;}
        public Tabuleiro tabuleiro {get; set;}

        public Peca (Tabuleiro tabuleiro, Cor cor){

            this.posicao = null;
            this.tabuleiro = tabuleiro;
            this.cor = cor;
            qteMovimento = 0;
        }

        public void incrementarQteMovimentos(){
            qteMovimento ++;
        }

    }
}