using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5COM25A1
{
    internal class ParkingTicket
    {
        private int ticketNumber;
        private Vehicle vehicle;
        private string driverName;

        public ParkingTicket(int ticketNumber, Vehicle vehicle, string driverName)
        {
            this.ticketNumber = ticketNumber;
            this.vehicle = vehicle;
            this.driverName = driverName;
        }

        public int TicketNumber { get => ticketNumber; set => ticketNumber = value; }
        public string DriverName { get => driverName; set => driverName = value; }
        internal Vehicle Vehicle { get => vehicle; set => vehicle = value; }
    }
}
