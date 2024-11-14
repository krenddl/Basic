using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikl3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a  = Convert.ToDouble(Console.ReadLine());
            double S = 0;
            if (a >= 0)
            {
                S = 1;
                for (int i = 2; i <= 8; i += 2)
                {
                    S *= i * i - a;
                }

            }
            else
                
            {

                for (int i = 3; i <= 9; i += 2)
                {
                    S += i - 2;
                }
            }
            Console.WriteLine(S);

        }
    }
}
