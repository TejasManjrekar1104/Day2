﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class NestedIf2
    {
        public static void Main5(string[] args)
        {

            Console.WriteLine("Enter your User NAME:- ");
            string username = Console.ReadLine();

            if(username == "tejasmanjrekar123")
            {

                Console.WriteLine("Enter your Password");
                string password = Console.ReadLine();

                if(password == "tejas123")
                {
                    Console.WriteLine("Your account balance is 10000/-");
                }
                else
                {
                    Console.WriteLine("Wrong Password");
                }
            }
            else
            {
                Console.WriteLine("Wrong username entered");
            }
        }
    }
}
