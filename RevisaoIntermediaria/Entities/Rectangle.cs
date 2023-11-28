using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using RevisaoIntermediaria.Entities.Enums;

namespace RevisaoIntermediaria.Entities
{
    public class Rectangle : Shapes
    {
        
        public double Width {get; set;}
        public double Height {get; set;}

        public Rectangle(){
        }

        public Rectangle(Color color, double width, double height) : base(color){

            Width = width;
            Height = height;

        }

        public override double Area()
        {
            return Width * Height;
        }

        

    }
}