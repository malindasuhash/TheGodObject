using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGodObject
{
    /// <summary>
    /// Base class that specify the stategy of feeding.
    /// </summary>
    public abstract class FeedableBase
    {
        protected IFeed _feed;

        protected FeedableBase(IFeed feed)
        {
            _feed = feed;
        }

        public abstract void Start();
    }
}
