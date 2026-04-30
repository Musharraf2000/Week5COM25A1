using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5COM25A1
{
    internal class Vehicle
    {
        private string brand;
        private string name;
        private int plateNumber;

        public Vehicle(string brand, string name, int plateNumber)
        {
            this.brand = brand;
            this.name = name;
            this.plateNumber = plateNumber;
        }

        public string Brand { get => brand; set => brand = value; }
        public string Name { get => name; set => name = value; }
        public int PlateNumber { get => plateNumber; set => plateNumber = value; }
    }
}
