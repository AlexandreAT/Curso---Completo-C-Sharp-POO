using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2
{
    public class Quarto
    {
        string Nome;
        string Email;
        int NumQuarto;

        public Quarto(string nome, string email, int numQuarto){

            Nome = nome;
            Email = email;
            NumQuarto = numQuarto;

        }

        public override string ToString(){
            return Nome + "; Email - " + Email;
        }

    }
}