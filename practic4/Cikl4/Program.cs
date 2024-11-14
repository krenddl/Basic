using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikl4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int S = 0;
            switch(a)
            {
                case 1:
                    for (int i = 0; i<=100; i+=5)
                    {
                        S += i;
                    }
                    Console.WriteLine(S);
                    break;

                case 2:
                    for (int j = 0; j <= 20; j += 5)
                    {
                        S += j;
                    }
                    Console.WriteLine(S);
                    break;
                case 3:
                    for (int j = 0;j <=10;  j += 5)
                    {
                        S += j;
                    }
                    Console.WriteLine(S);
                    break;
                default:
                    S = 100;
                    Console.WriteLine(S);
                    break;
            }
        }
    }
}
