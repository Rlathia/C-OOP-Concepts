using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class Employee
    {
        protected string FirstName { get; set; }
        protected decimal Salary { get; set; }

        //has-a relationship
        protected EmployeeIDInfo empIDInfo = new EmployeeIDInfo();

        public void SetEmployeeIDInfo(int idnum, string sinNum)
        {
            empIDInfo.IDNum = idnum;
            empIDInfo.sinNum = sinNum;
        }

        public void GetEmployeeIDInfo()
        {
            Console.WriteLine("The Employee has id {0} and the sin number is {1}", empIDInfo.IDNum, empIDInfo.sinNum);
        }
        public Employee()
        {
            this.FirstName = "Rajvi Lathia";
            this.Salary = 70000;
        }

        public Employee(string fname, decimal salary)
        {
            this.FirstName = fname;
            this.Salary = salary;
        }

        public virtual void Work() {
            Console.WriteLine("Employee " + FirstName + " works.");
        }

        public void Pause() { 
            Console.WriteLine("Employee " + FirstName + " paused work.");
        }

    }
}
