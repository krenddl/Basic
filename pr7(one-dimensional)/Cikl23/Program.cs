using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikl23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Введите число ");
            uint numbers = Convert.ToUInt32(Console.ReadLine());
            do
            {
                if (numbers % 10==7)
                {
                    count++;
                }
             numbers = numbers / 10;

            } while (numbers > 0);
            Console.WriteLine(count);
        }
    }
}
