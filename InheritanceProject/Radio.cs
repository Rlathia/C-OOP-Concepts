using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    //Child Class
    class Radio : ElectricalEquipment
    {
        public Radio(bool isON, string brand) : base (isON, brand)
        {

        }

        public void Play()
        {
            if (IsON)
                Console.WriteLine(Brand + " Radio is playing .... ");
            else
                Console.WriteLine(Brand + " Radio is OFF... Please turn it on");
        }
    }
}
