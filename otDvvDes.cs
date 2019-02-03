using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dv = Console.ReadLine();
            int des = 0;
            int length = dv.Length;
            for (int i = 0; i < length ;i++)
            {
                des = des * 2 + (dv[i] - '0');
            }
            Console.WriteLine(des);
        }
    }
}
