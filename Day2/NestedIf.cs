using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class NestedIf
    {
        public static void Main4(string[] args)
        {
            int a = 34; int b = 54; int c = 301; int d = 58;

            if (a > b && a>c && a>d)
            {
                Console.WriteLine("A is large than all");
            }
            else
            {
                if(b>c && b > d)
                {
                    Console.WriteLine("B is large than all");
                }
                else
                {
                    if (c > d)
                    {
                        Console.WriteLine("C is large than all");
                    }
                    else
                    {
                        Console.WriteLine("D is large than all");
                    }
                }
            }
            
        }
    }
}
