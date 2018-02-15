using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Bolme
    {
        public double bolmeIslemi(double a, double b)
        {
            if(b==0)
            {
               Console.WriteLine("Bölüm 0 olamaz");
               return -1;
                
            }
            
            return a / b;
        }
    }
}
