using System;
using System.Collections.Generic;

namespace ChallengeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Shawn");
            names.Add("Mary");
            names.Add("Dave");
            foreach  (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
