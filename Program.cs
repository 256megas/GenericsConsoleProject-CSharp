using System;
//Create Dictionary
//using System.Collections.Generic;

namespace GenericsConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Dictionary
            //Dictionary<string, int> prices = new Dictionary<string, int>(5);
            //prices.Add("Watermelon", 5);
            //prices.Add("Car", 100);
            //Console.WriteLine( prices["Watermelon"]);

            Console.WriteLine(Utility.compareValue("hello", "hello"));
            Console.WriteLine(Utility.compareTypes("hello", 1));

            Console.ReadKey();

        }
    }

    class Utility
    {
        public static bool compareValue<T01, T02>(T01 value01, T02 value02)
        {
            return value01.Equals(value02);
        }

        public static bool compareTypes<T01, T02>(T01 type01, T02 type02)
        {
            return typeof(T01).Equals (typeof(T02));
        }

    }


}
