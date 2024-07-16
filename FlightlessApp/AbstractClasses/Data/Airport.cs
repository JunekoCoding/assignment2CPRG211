using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Data
{
    public class Airport
    {
        string AIRPORT_TXT = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\..\\..\\Assignments\\OOP2 Assignment 2\\airports.csv");

        public static List<AirportTypes> airports = new List<AirportTypes>();
        public Airport()
        {
            populateAirports();
        }

        private void populateAirports()
        {
            AirportTypes type;

            foreach (string line in File.ReadLines(AIRPORT_TXT))
            {
                string[] parts = line.Split(",");
                int airportCode = int.Parse(parts[0]);
                string airportName = parts[1];
                

                type = new AirportTypes(airportCode, airportName);
                airports.Add(type);
            }
        }

        public static List<AirportTypes> GetUsers() 
        {
            return airports;
        }


    }
   
}
