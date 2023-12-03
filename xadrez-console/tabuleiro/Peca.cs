using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace xadrez_console.tabuleiro
{
    abstract public class Peca
    {

        public Posicao posicao {get; set;}
        public Cor cor {get; protected set;}
        public int qteMovimento {get; set;}
        public Tabuleiro tab {get; set;}

        public Peca (Tabuleiro tab, Cor cor){

            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            qteMovimento = 0;
        }

        public void incrementarQteMovimentos(){
            qteMovimento ++;
        }

        public void decrementarQteMovimentos(){
            qteMovimento --;
        }

        public bool existeMovimentosPossiveis(){
            bool[,] mat = movimentosPossiveis();
            for (int i=0; i<tab.linhas;i++){
                for (int j=0; j<tab.colunas;j++){
                    if(mat[i,j]){
                        return true;
                    }
                }
            }
            return false;
        }

        public bool movimentoPossivel(Posicao pos){
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();

    }
}