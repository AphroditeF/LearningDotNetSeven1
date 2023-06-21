using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string myString = "test";
            myString += ". second part.";
            Console.WriteLine(myString);

            string[] myStringArr = myString.Split(".");
            Console.WriteLine(myStringArr[0]);
            Console.WriteLine(myStringArr[1]);
            Console.WriteLine(myStringArr[2]);

            //ghjgfhjj

            // See https://aka.ms/new-console-template for more information
            Console.WriteLine(args[0]);
        }
    }
}