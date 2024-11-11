using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] starray = {"Габитов А.","Габитов Б.","Попов Г.","Комаров Т.","Комаров Н.","Иванова Д."};
            foreach (string st in starray)
            {
                Console.WriteLine(st);
            }
            for (int i = 0; i < starray.Length; i++)
            {
                string[] students = starray[i].Split(',');
                if (students[0] == stu)
            }

        }
    }
}
