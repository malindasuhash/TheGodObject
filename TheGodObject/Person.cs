using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGodObject
{
    /// <summary>
    /// Generic class to represent a human.
    /// </summary>
    public abstract class Person : ICanCry, IFeedable, ICanPoo, ICanSleep
    {
        private FeedableBase _feedability;

        protected Person(Gender gender, string name, FeedableBase feedable)
        {
            Gender = gender;
            Name = name;
            _feedability = feedable;
        }

        public Gender Gender { get; protected set; }

        public string Name { get; protected set; }

        public abstract void Cry();

        public abstract void Sleep();

        public void Poo()
        {
            Console.WriteLine("Does the job");
        }

        public void Feed()
        {
            _feedability.Start();
        }
    }

    /// <summary>
    /// The Gender of the Human.
    /// </summary>
    public enum Gender
    {
        Male,

        Female
    }

}
