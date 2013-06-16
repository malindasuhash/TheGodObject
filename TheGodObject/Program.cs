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
            var babyFeed = new BabyFeedable(new BottleFeed());
            var specialOne = new TheSpecialOne(Gender.Male, "Amith", babyFeed);

            Console.WriteLine(specialOne);

            specialOne.Feed();
            specialOne.Cry();
            specialOne.Poo();
            specialOne.Sleep();

            Console.ReadKey();
        }
    }
}
