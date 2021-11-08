using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class Boss : Employee
    {
        private string CompanyCar { get; set; }
       
        public Boss(string companyCar, string fname, decimal salary) : base (fname, salary)
        {
            this.CompanyCar = companyCar;
        }
        public void Lead() {
            Console.WriteLine("Boss " + FirstName + " leads with company car " + CompanyCar);
        }

    }
}
