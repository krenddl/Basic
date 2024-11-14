using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikl2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (double C = -50; C<=50;  C++)
            {
                double F = 1.8 * C + 32;
                Console.WriteLine($"По Цельсию: {C}     По Фаренгейту: {F}");
            }
        }
    }
}
