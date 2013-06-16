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
        protected IFeedStyle _feedStyle;

        protected FeedableBase(IFeedStyle feed)
        {
            _feedStyle = feed;
        }

        public abstract void Start();
    }
}
