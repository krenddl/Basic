using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int attemption = 0;
            Console.WriteLine("Введите радиус мишени ");
            uint radius = Convert.ToUInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Введите x ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите y ");
                double y = Convert.ToDouble(Console.ReadLine());
                double diag =(Math.Pow(x+radius,2)+Math.Pow(y-radius,2));
                if (diag < Math.Pow(radius, 2))
                {
                    Console.WriteLine("автомат 5 за 2 семестра(попал)");
                    break;
                }
                else
                    Console.WriteLine("не попал");

                attemption++;
            }
            while(attemption <= 10);


            
        

        }
    }
}
