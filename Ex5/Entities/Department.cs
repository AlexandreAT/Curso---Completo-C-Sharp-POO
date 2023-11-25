using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Ex5.Entities
{
    public class Department
    {
        public string Name {get; set;}

        public Department(){
        }

        public Department(string name){
            Name = name;
        }

        public override string ToString()
        {
            return "Derpartamento: "+ Name;
        }

    }
}