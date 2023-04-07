using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class IfElse
    {
        public static void Main2(string[] args)
        {
            Console.WriteLine("What is your AGE?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("You are not Eligible for license");
            }
            else
            {
                Console.WriteLine("You are Eligible for License");
            }
        }
    }
}
