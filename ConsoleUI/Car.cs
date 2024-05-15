using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Car is driving abstractly!");
        }

        public bool HasTrunk { get; set; } 
    }
}
