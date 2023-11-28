using System;
using System.Collections.Generic;
using RevisaoIntermediaria.Entities.Enums;
using System.Linq;
using System.Threading.Tasks;

namespace RevisaoIntermediaria.Entities
{
    public class Circle : Shapes
    {
        public double Radius {get; set;}

        public Circle(){
        }

        public Circle(Color color, double radius) : base(color){

            Radius = radius;

        }

        public override double Area()
        {
            return Math.PI * Radius*Radius;
        }
    }
}