using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            bool flag = true;
            foreach (char item in number)
            {
                if (item != '0' && item != '1')
                {
                    flag = false;
                }

            }
            if (flag)
            {
                int sum = 0;
                int num1 = number.Length - 1;
                for (int i = 0; i < number.Length; i++)
                {
                    int num = number[i] - '0';
                    sum += (int)(num * Math.Pow(2, num1));
                    num1 -= 1;
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("вводи заного");
            }
        }
    }
}
