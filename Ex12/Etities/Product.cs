using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex12.Etities
{
    public class Product
    {
        
        public string Name {get; set;}
        public double Value {get; set;}
        public int Quantity {get; set;}

        public Product(){
        }

        public Product(string name, double value, int quantity){

            Name = name;
            Value = value;
            Quantity = quantity;

        }

        public double TotalValue(){
            return Value * Quantity;
        }

        public override string ToString()
        {
            return Name+", "+Value+", "+Quantity;
        }

    }
}