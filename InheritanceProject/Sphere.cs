﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class Sphere : Shape
    {
        protected double Radius { get; set; }

        public Sphere(string name, double radius) : base(name)
        {
            Name = "Sphere";
            Radius = radius;
        }
        public override double Volume()
        {
            return Math.PI * (Math.Pow(Radius, 3)) * 4 / 3;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Sphere : Volume is {Volume()}");
        }
    }
}
