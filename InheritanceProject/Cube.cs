using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class Cube : Shape
    {
        protected double Length { get; set; }
        public Cube(string name, double length) : base (name)
        {
            //Console.WriteLine("This is a class CUBE inheriting an abstract class SHAPE");
            Length = length;
            //GetInfo();
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Cube : Volume = {Volume()}");
        }
        public override double Volume()
        {
            return Math.Pow(Length, 3);
        }
    }
}
