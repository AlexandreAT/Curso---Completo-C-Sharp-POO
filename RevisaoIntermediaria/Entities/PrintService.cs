using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevisaoIntermediaria.Entities
{
    public class PrintService
    {
        
        private int[] values = new int[10];
        private int count = 0;

        public void AddValue(int value){

            if(count == 10){

                throw new InvalidOperationException("O conjunto esta cheio!");

            }

            values[count] = value;
            count++;

        }

        public int First(){

            if(count == 0){
                throw new InvalidOperationException("O conjunto esta vazio!");
            }

            return values[0];
        }

        public void Print(){

            Console.Write("[");
            for(int i = 0; i < count-1; i++){

                Console.Write(values[i]+", ");

            }
            if(count > 0){
                Console.Write(values[count-1]);
            }
            Console.WriteLine("]");
        }

    }
}