using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikl22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a ");
            double a = double.Parse(Console.ReadLine());
            double i = 0;

            double S = 0;
            if (a < 0)
            {
                i = 3;
                do
                {
                    S+=  i - 2;
                    i += 2;
                } 
                while(i <= 9);
            }
            else
            {
                S = 1;
                i = 2;
                do
                {
                    S *= i * i - a;
                    i += 2;
                } 
                while(i <= 8);

                
                
            }
            Console.WriteLine(S);
        }
    }
}
