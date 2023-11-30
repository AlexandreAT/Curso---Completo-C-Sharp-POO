using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex11.Exceptions
{
    public class DomainException : ApplicationException
    {

        public DomainException(string message) : base (message){
            
        }
        
    }
}