using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stroka = Console.ReadLine();
            int count = 1;
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            for (int i = 1; i <stroka.Split(' ').Length; i+=2)
            {
                if(i<stroka.Split(' ').Length)
                    Console.WriteLine(stroka.Split(' ')[i]);
            }
        }
    }
}
