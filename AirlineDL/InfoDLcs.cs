using AirlineModel;
using System.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;

namespace AirlineDL
{
    public class InfoDL
    {
        internal string passenger;

        public Info GetBookingInfo()
        {
            return new Info { passenger = "Jeff Satur", classtype = "First Class" ,seatnum = "01",origin = "Thailand", destination = "Philippines", flightdate = DateTime.Now };

        }
        public Info GetInfo()
        {
            return new Info { passenger = "John Stamos", classtype = "Economy Class", seatnum = "02", origin = "Los Angeles", destination = "Philippines", flightdate = DateTime.Now };
        }

        public Info GetIdea()
        {
            return new Info { passenger = "Jihoon Lee", classtype = "Business Class", seatnum = "03", origin = "South Korea", destination = "Philippines", flightdate = DateTime.Now };
        }

        public Info GetIwan()
        {
            return new Info { passenger = "Mingyu Kim", classtype = "First Class", seatnum = "04", origin = "South Korea", destination = "Philippines", flightdate = DateTime.Now };
        }

        public Info GetIda()
        {
            return new Info { passenger = "Wonwoo Jeon", classtype = "Economy Class", seatnum = "05", origin = "South Korea", destination = "Philippines", flightdate = DateTime.Now };
        }
    }
}
