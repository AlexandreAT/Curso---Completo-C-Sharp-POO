using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using RevisaoIntermediaria.Entities.Enums;

namespace RevisaoIntermediaria.Entities
{
    abstract public class Shapes
    {

        public Color Color {get; set;}

        public Shapes (){
        }

        public Shapes (Color color){
            Color = color;
        }

        public abstract double Area();

        public override string ToString()
        {
            return "Area: "+Area().ToString("F2", CultureInfo.InvariantCulture);
        }
        
    }
}