using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    //Parent Class 
    class ElectricalEquipment
    {
        public bool IsON { get; set; }
        public string Brand { get; set; }
        public ElectricalEquipment(bool isON, string brand)
        {
            this.IsON = isON;
            this.Brand = brand;
        }

        public void SwitchON()
        {
            IsON = true;
            Console.WriteLine("Radio is switched ON");
        }

        public void SwitchOFF()
        {
            IsON = false;
            Console.WriteLine("Radio is switched OFF");
        }
        public virtual void Play()
        {
            if (IsON)
                Console.WriteLine("Electrical Equipment is playing .... ");
            else
                Console.WriteLine("Electrical Equipment is OFF... Please turn it on");
        }

        public virtual void VMethod()
        {
            Console.WriteLine("This is inside virtual method");
        }  
    }
}
