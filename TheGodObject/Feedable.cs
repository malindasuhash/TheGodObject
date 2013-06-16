﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGodObject
{
    /// <summary>
    /// Feeding!
    /// </summary>
    public class Feedable : FeedableBase
    {
        public Feedable(IFeedStyle feed)
            : base(feed)
        {
        }

        public override void Start()
        {
            Console.WriteLine("Starting to feed.");

            _feed.Feed();
        }
    }
}
