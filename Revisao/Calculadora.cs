using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Revisao
{
    public class Calculadora
    {
        
        public static double pi = 3.14;

        public static double Circuferenia(double r){
            return 2.0 * pi * r;
        }

        public static double Volume(double r){
            return 4.0 / 3.0 * pi * Math.Pow(r, 3);
        }

    }
}