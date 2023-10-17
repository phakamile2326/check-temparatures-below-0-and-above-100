using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_temparatures_below_0_and_above_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(check(120, -1));
            Console.WriteLine(check(-1,120));
            Console.WriteLine(check(2,120));
            Console.ReadKey();

        }
        public static bool check(int temp1, int temp2)
        {
            return temp1 < 0 && temp2 > 100 || temp2 < 0 && temp1 > 100;
        }
            
    }
}
