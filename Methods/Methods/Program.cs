﻿// Write a method that asks the user for his name and prints Hello, <name>!. Write a program to test this method.

namespace _01.Say_Hello_
{
    using System;

    public class SayHello
    {
        static void Main()
        {
            string name = Console.ReadLine();
            Console.WriteLine(SayHelloFunction(name));
        }

        static string SayHelloFunction(string name)
        {
            string hello = string.Format("Hello, {0}!", name);

            return hello;
        }
    }
}

/*
using System;

namespace _01_Say_Hello
{
    class SayHello
    {
        static void Main()
        {
            //print output
            Console.WriteLine("Hello, {0}!", GetName());
        }

        public static string GetName()
        {
            // read the Name off the console
            return Console.ReadLine();
        }
    }
}
*/