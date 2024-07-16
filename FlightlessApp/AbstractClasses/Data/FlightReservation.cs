using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Data
{
    public class FlightReservation
    {
        public int FlightNumber { get; set; }
        public string AirlineName { get; set; }
        public string DepAirportCode { get; set; }
        public string DestAirportCode { get; set; }
        public string Day {  get; set; }
        public int Time {  get; set; }
        public int Distance { get; set; }
        public int Cost { get; set; }

        public string Citizenship { get; set; }
        public int ReservationID { get; set; }


        public FlightReservation()
        {
        }

        public FlightReservation(int flightNumber, string airlineName, string depAirportCode, string destAirportCode, string day, int time, int distance, int cost)
        {
            this.FlightNumber = flightNumber;
            this.AirlineName = airlineName;
            this.DepAirportCode = depAirportCode;
            this.DestAirportCode = destAirportCode;
            this.Day = day;
            this.Time = time;
            this.Distance = distance;
            this.Cost = cost;
        }
    }
}
