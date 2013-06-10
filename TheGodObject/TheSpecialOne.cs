using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGodObject
{
    /// <summary>
    /// My special one!
    /// </summary>
    public class TheSpecialOne : Person
    {
        public TheSpecialOne(Gender gender, string name): 
            base(gender, name)
        {
        }

        public override void Cry()
        {
            Console.WriteLine("Cry - Very loud");
        }

        public override void Feed()
        {
            Console.WriteLine("Special baby is feeding");
        }

        public override void Sleep()
        {
            Console.WriteLine("Sleeps like an angel");
        }

        public override string ToString()
        {
            return "***** " + Name + " ******";
        }
    }
}
