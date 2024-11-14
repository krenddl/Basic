using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint num1 = 0;
            uint num = uint.Parse(Console.ReadLine());
            for (uint Num1 = 0; Num1<num; Num1++)
            {
                num1 += Num1;
            }
            Console.WriteLine(num1 / 5);
        }
    }
}
