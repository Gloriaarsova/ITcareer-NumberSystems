using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otDesvDv
{
    class Program
    {
        static void Main(string[] args)
        {
            var des = int.Parse(Console.ReadLine());
            string sh = "";
            while(des!=0)
            {
                if (des % 16 == 0) sh = '0' + sh;
                else if (des % 16 == 1) sh = '1' + sh;
                else if (des % 16 == 2) sh = '2' + sh;
                else if (des % 16 == 3) sh = '3' + sh;
                else if (des % 16 == 4) sh = '4' + sh;
                else if (des % 16 == 5) sh = '5' + sh;
                else if (des % 16 == 6) sh = '6' + sh;
                else if (des % 16 == 7) sh = '7' + sh;
                else if (des % 16 == 8) sh = '8' + sh;
                else if (des % 16 == 9) sh = '9' + sh;
                else if (des % 16 == 10) sh = 'A' + sh;
                else if (des % 16 == 11) sh = 'B' + sh;
                else if (des % 16 == 12) sh = 'C' + sh;
                else if (des % 16 == 13) sh = 'D' + sh;
                else if (des % 16 == 14) sh = 'E' + sh;
                else if (des % 16 == 15) sh = 'F' + sh;
                des = des / 16;
            }
            Console.WriteLine(sh);
        }
    }
}
