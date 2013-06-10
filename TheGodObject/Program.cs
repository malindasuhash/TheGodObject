using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGodObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var specialOne = new TheSpecialOne(Gender.Male, "Amith");

            Console.WriteLine(specialOne);

            specialOne.Feed();
            specialOne.Cry();
            specialOne.Poo();
            specialOne.Sleep();

            Console.ReadKey();
        }
    }
}
