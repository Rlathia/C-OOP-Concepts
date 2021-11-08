using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class Program
    {
        static void Main(string[] args)
        {
        //Inheritance 1
            Radio myRadio = new Radio(false, "Sony");
            //method of base class
            myRadio.SwitchON();
            //method of base and child class but it will run child class method
            myRadio.Play();
            ElectricalEquipment equip = new ElectricalEquipment(true, "Haier");
            equip.Play();
            myRadio.VMethod();

        //Inheritance 2

            Post post1 = new Post();
            Console.WriteLine(post1.ToString());

            ImagePost imagePost = new ImagePost("Check out my new shoes", false, "RL", "https://myshoes.com/image");
            Console.WriteLine(imagePost.ToString());

         //Inheritance 3

            Employee emp1 = new Employee();
            Employee emp2 = new Employee("Ankit Patel", 60000);
            Boss boss1 = new Boss("Baleno", "Jitendrabhai Patel", 80000);
            Trainee trainee1 = new Trainee("Heli Bagadia", 15, 24, 20000);

            Console.WriteLine("\n");
            boss1.Lead();
            trainee1.Work();
            emp2.Work();

            //child class Trainee using public method of parent class Employee
            trainee1.Pause();

    //Polymorphism
            Console.WriteLine("\n");
            //object of parent class instantiated as a child class
            Employee emp3 = new Trainee("Ila Patel", 10, 20, 20000);

            //object of parent class uses overrided method of child class
            emp3.Work();

            //has a relationship
            emp2.SetEmployeeIDInfo(10, "598789234");
            emp1.SetEmployeeIDInfo(9, "789567894");

            emp1.GetEmployeeIDInfo();
            emp2.GetEmployeeIDInfo();

    //Abstract class and method
            Console.WriteLine("\n");
            Cube cube1 = new Cube("Rajvi", 10);

    //Polymorphism
            object cube2 = new Cube("Object" ,7);
            Cube cube3 = (Cube)cube2;
            Console.WriteLine($"cube3 : Volume = {cube3.Volume()}");

            Shape[] shapes =
            {
                new Sphere("Sphere",4),
                new Cube("Cube",3)
            };
        
        //as and is keyword
            foreach(var shape in shapes)
            {
                shape.GetInfo();
                //Console.WriteLine($"It has a volume : {shape.Volume()}");
                Cube iceCube = shape as Cube;
                if(iceCube is null)
                {
                    Console.WriteLine("This shape is not a cube");
                }
                if(iceCube is Cube)
                {
                    Console.WriteLine("This shape is a Cube");
                }



            }

            Console.Read();
        }
    }
}
