using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGodObject
{
    /// <summary>
    /// Feeding!
    /// </summary>
    public class BabyFeedable : FeedableBase
    {
        public BabyFeedable(IFeedStyle feed)
            : base(feed)
        {
        }

        public override void Start()
        {
            Console.WriteLine("Starting to feed baby style!.");

            _feedStyle.Feed();
        }
    }
}
