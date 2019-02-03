using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var des = int.Parse(Console.ReadLine());
            string dv = " ";
            while(des!=0)
            {
                if (des % 2 == 0) dv = '0' + dv;
                else dv = '1' + dv;
                des = des / 2;
            }
            Console.WriteLine(dv);
        }
    }
}
