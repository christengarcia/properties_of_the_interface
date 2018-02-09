/*
 *  C# Program to Demonstrate Properties of the Interface
 */

using System;

namespace properties_of_the_interface
{

    interface IValue
    {
        int Count { get; set; }
        string Name { get; set; }
    }

    class Image : IValue
    {
        public int Count
        {
            get;
            set;
        }

        string _name;

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
