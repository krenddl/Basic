using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringarray = {"Габитов А.И.", "Машукова М.А.", "Марданов А.Б.", "Габитов В.В.", "Марданов Т.Л.", "Марданов А.А."};

            for (int i = 0; i < stringarray.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < stringarray.Length; j++)
                {
                    if (stringarray[i].Split(' ')[0] == stringarray[j].Split(' ')[0] && i!=j)
                    {
                        count++;
                    }
                }
               Console.WriteLine(stringarray[i] + count);
            }
        }
    }
}
