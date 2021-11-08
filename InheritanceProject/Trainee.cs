using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class Trainee : Employee
    {
        protected int SchoolHours { get; set; }
        protected int WorkingHours { get; set; }

        public Trainee(string fname, int sHours, int wHours, decimal salary ) : base (fname, salary)
        {
            this.SchoolHours = sHours;
            this.WorkingHours = wHours;
        }
        public void Learn() {
            Console.WriteLine("Trainee " + FirstName + " has learned for " + SchoolHours + " hours.");
        }

        public override void Work()
        {
            Console.WriteLine("Trainee " + FirstName + " worked " + WorkingHours + " hours.");
        }
    }
}
