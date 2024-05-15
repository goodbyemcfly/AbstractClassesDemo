using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle is driving abstractly!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle is driving virtually!");
        }

        public bool HasSideCar { get; set; }
    }
}
