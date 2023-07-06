using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicles
    {

        public bool HasTrunk { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("The car runs really fast");

        }

    }
}
