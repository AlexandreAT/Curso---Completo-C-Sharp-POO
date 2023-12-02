using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xadrez_console.tabuleiro
{
    public class TabuleiroException : Exception
    {
        
        public TabuleiroException(string msg) : base(msg){
        }

    }
}