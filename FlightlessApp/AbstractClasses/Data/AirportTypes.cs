using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Data
{
    public class AirportTypes
    {
        public int AirportCode { get; set; }
        public string AirportName { get; set; }

        public AirportTypes()
        {
        }

        public AirportTypes(int airportCode, string airportName)
        {
            this.AirportCode = airportCode;
            this.AirportName = airportName;
         
        }
    }
}
