using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5COM25A1
{
    internal class CarPark
    {
        private static List<ParkingTicket> parkedVehicles = new List<ParkingTicket>();
        private static int totalVehiclesParked = 0;
        private static int parkingTicketNumberCounter = 0;

        public static int TotalVehiclesParked { get => totalVehiclesParked; set => totalVehiclesParked = value; }
        public static int ParkingTicketNumberCounter { get => parkingTicketNumberCounter; set => parkingTicketNumberCounter = value; }
        internal static List<ParkingTicket> ParkedVehicles { get => parkedVehicles; set => parkedVehicles = value; }

        public static void ParkVehicle()
        {
            Console.WriteLine("Enter the brand of the vehicle: ");
            string brand = Console.ReadLine();
            Console.WriteLine("Enter the name of the vehicle: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the plate number of the vehicle: ");
            int plateNumber = int.Parse(Console.ReadLine());
            
          

            foreach (ParkingTicket ticket in parkedVehicles)
            {
                if (ticket.Vehicle.PlateNumber == plateNumber)
                {
                    Console.WriteLine("This vehicle is already parked.");
                    return;
                }
            }
            Console.WriteLine("Enter the driver's name: ");
            string driverName = Console.ReadLine();
            Vehicle vehicle = new Vehicle(brand, name, plateNumber);
            ParkingTicket t1 = new ParkingTicket(ParkingTicketNumberCounter, vehicle, driverName);
            parkedVehicles.Add(t1);
            parkingTicketNumberCounter++;
            totalVehiclesParked++;
        }

        public static void RemoveVehicle()
        {
            Console.WriteLine("Enter the plate number of the vehicle: ");
            int plateNumber = int.Parse(Console.ReadLine());
            int index = 0;
            bool found = false;
            foreach (ParkingTicket ticket in parkedVehicles)
            {
                if (ticket.Vehicle.PlateNumber == plateNumber)
                {
                    index = parkedVehicles.IndexOf(ticket);
                    found = true;
                }
            }
            if (found) {
                parkedVehicles.RemoveAt(index);
                totalVehiclesParked--;
                Console.WriteLine("Vehicle Removed");
               
            }
            else
            {
                 Console.WriteLine("Vehicle not found.");
            }
            
        }
    }
}
