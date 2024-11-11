using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace string2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            bool flag = false;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == '0' || num[i] == '1')
                {
                    flag = true;
                    break;
                }
                else
                {
                    Console.WriteLine("числы должны быть только 0 и 1!!");
                    break;
                }
            }

            if (flag == true)
            {
                int key = num.Length - 1;
                int sum = 0;
                for (int i = 0;i < num.Length;i++)
                {
                    int num1 = num[i] - '0';
                    sum += (int)(num1 * Math.Pow(2, key));
                    key = key-1;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
