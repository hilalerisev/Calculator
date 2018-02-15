using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Bolme
    {
        public static void bolmeIslemi(double a, double b)
        {
            double result = 0;

            try
            {
                result = kontrol(a, b);
                Console.WriteLine("Sonuç: {0}", result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Bölen 0 olamaz.");
            }
        }

        public static double kontrol(double a, double b)
        {
            if (b == 0)
                throw new System.DivideByZeroException();
            return a / b;
        }

    }
}
