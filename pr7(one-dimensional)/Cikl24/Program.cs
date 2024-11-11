using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikl24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ");
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;
            if (n % 2 == 0) 
            {
                int i = 2;

                do
                {
                    factorial *= i;
                    i += 2;

                } while (i <= n);

            }
            else
            {
                int i = 1;
                do
                {
                    factorial *= i;
                    i += 2;
                } while(i <= n);
            }
            Console.WriteLine(factorial);
        }
    }
}
