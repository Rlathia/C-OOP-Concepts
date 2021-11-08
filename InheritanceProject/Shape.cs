using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    abstract class Shape
    {
        protected string Name { get; set; }

        public Shape(string name)
        {
            //Console.WriteLine("This is an Abstract class called SHAPE");
            Name = name;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"\nThis is a {Name} Shape");
        }
        public abstract double Volume();
    }
}
