using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Data
{
    public class Flight
    {
        public string code;

        public string airline;

        public string from;

        public string to;

        public string weekday;

        public Flight(string code)
        {
            this.code = code;
        }
        public Flight(string code, string airline, string from, string to, string day)
        {
            this.code = code;
            this.airline = airline;
            this.from = from;
            this.to = to;
            this.day = day;
        }

        public string Code { get => code; set => code = value; }
        public string Airline { get => airline; set => airline = value; }
        public string From { get => from; set => from = value; }
        public string To { get => to; set => to = value; }
        public string day { get => day; set => day = value; }


        public override bool Equals(object obj)
        {
            return obj is Flight flight &&
                   code == flight.code &&
                   airline == flight.airline &&
                   from == flight.from &&
                   to == flight.to &&
                   day == flight.day &&
                   Code == flight.Code &&
                   Airline == flight.Airline &&
                   From == flight.From &&
                   To == flight.To &&
                   day == flight.day;
        }



        public string toString()
        {
            return Code;
        }



        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }

}
