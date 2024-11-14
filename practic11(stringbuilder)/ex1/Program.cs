using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            string name1 = "C#";
            string name2 = " ";
            string name3 = "Programming";
            builder.Append(name1);
            builder.Append(name2);
            builder.Append(name3);
            Console.WriteLine(builder.ToString());
            builder.Remove(0, builder.Length);
            builder.Append(name3);
            builder.Append(name2);
            builder.Append(name1);
            Console.WriteLine(builder.ToString());
            builder.Append($" {name1} is cool and fun!");
            Console.WriteLine(builder.ToString());
            builder.Replace(" and fun", " ");
            Console.WriteLine(builder.ToString());
            builder.Insert(builder.Length/2, "C#");
            Console.WriteLine(builder.ToString());
        }
    }
}
