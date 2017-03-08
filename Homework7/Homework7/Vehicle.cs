using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Vehicle
    {
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double Power { get; set; }

        virtual public void PrintInfo()
        {
            Console.Write("Please enter License Plate: ");
            string license = Console.ReadLine();
            string license2 = license.Insert(license.Length - 2, "-");
            LicensePlate = license2.Insert(2, "-");
            LicensePlate = LicensePlate.ToUpper();

            Console.Write("Please enter the manufacturer: ");
            string manufacturer = Make;
            manufacturer = Console.ReadLine();

            Console.Write("Please enter the model: ");
            string model = Model;
            model = Console.ReadLine();

            Console.Write("Please enter year: ");
            int year = Year;
            year = int.Parse(Console.ReadLine());

            Console.Write("Please enter the color: ");
            string color = Color;
            color = Console.ReadLine();

            Console.WriteLine("===========================");
            Console.WriteLine($"License plate number: {LicensePlate}");
            Console.WriteLine($"Manufacturer: {manufacturer}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine("============================");
        }
    }
}
