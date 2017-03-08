using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            do {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1) Create a new car");
                Console.WriteLine("2) Create a new truck");
                Console.WriteLine("3) Exit");
                int playerChoice = int.Parse(Console.ReadLine());

                if (playerChoice == 1)
                {
                    Car myCar = new Car();
                    myCar.PrintInfo();
                }
                else if (playerChoice == 2)
                {
                    Truck myTruck = new Truck();
                    myTruck.PrintInfo();
                }
                else if (playerChoice == 3)
                {
                    Environment.Exit(3);
                    exit = true;
                }

            } while (!exit);
            Console.ReadLine();
        }
    }
}
