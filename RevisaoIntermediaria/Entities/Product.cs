using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace RevisaoIntermediaria.Entities
{
    public class Product : IComparable
    {
        
        public string Name {get; set;}
        public double Value {get; set;}

        public Product(){
        }

        public Product(string name, double value){

            Name = name;
            Value = value;

        }

        public override string ToString()
        {
            return Name +", "+ Value.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Product)){
                throw new ArgumentException("Não é um produto!");
            }
            Product other = obj as Product;
            return Value.CompareTo(other.Value);
        }
    }
}