using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringarray = { "Габитов А.И.", "Машукова М.А.", "Марданов А.Б.", "Габитов В.В.", "Марданов Т.Л" };

            foreach (string str in stringarray)
            {
                Console.WriteLine(str);
            }

            for (int i = 0; i < stringarray.Length; i++)
            {
                int count = 0;
                string lastName = stringarray[i].Split(',')[0]; // Получаем фамилию

                for (int j = 0; j < stringarray.Length; j++)
                {
                    if (i != j && stringarray[j].StartsWith(lastName)) // Проверяем на совпадение фамилии, исключая самого студента
                    {
                        count++;
                    }
                }

                Console.WriteLine($"{lastName} кол-во однофамильцев = {count}");
            }
        }
    }
}
