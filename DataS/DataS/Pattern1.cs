using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataS
{
    class Pattern1
    {
        public static void PrintPattern(int n)
        {
            n = 4;
            int d = 7;
            for(int i = 0; i < d;i++)
            {
                for (int j = 0; j < d; j++)
                {
                    Console.Write("{0}", n);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
