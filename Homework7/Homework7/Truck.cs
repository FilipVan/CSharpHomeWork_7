using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Truck: Vehicle
    {
        public double Capacity { get; set; }

        public override void PrintInfo()
        {
            Console.Write("Enter capacity: ");
            double capacity = Capacity;
            capacity = double.Parse(Console.ReadLine());
            base.PrintInfo();
            
        }
    }
}
