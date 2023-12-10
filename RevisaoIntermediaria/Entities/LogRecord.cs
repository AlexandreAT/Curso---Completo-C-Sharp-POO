using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevisaoIntermediaria.Entities
{
    public class LogRecord
    {
        
        public string Username {get; set;}
        public DateTime Instante {get; set;}

        public LogRecord(string username, DateTime isntante){
            Username = username;
            Instante = Instante;
        }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object obj)
        {

            if(!(obj is LogRecord)){
                throw new ArgumentException("Não é um registro de usuário!");
            }

            LogRecord other = obj as LogRecord;
            return Username.Equals(other.Username);
        }

    }
}