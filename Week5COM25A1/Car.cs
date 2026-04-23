using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5COM25A1
{
    internal class Car
    {
        private string brand;
        private string model;
        private static int carCount = 0;

        public Car(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
            carCount++;
        }

        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public static int CarCount { get => carCount; set => carCount = value; }
    }
}
