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
        protected Person(Gender gender, string name)
        {
            Gender = gender;
            Name = name;
        }

        public Gender Gender { get; protected set; }

        public string Name { get; protected set; }

        public abstract void Cry();

        public abstract void Feed();

        public abstract void Sleep();

        public void Poo()
        {
            Console.WriteLine("Does the job");
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
