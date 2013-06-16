using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGodObject
{
    /// <summary>
    /// Bottle feeding.
    /// </summary>
    public class BottleFeed : IFeedStyle
    {
    
        public void Feed()
        {
            Console.WriteLine("Bottle feeding");
        }
    }
}
