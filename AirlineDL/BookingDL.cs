using System.Reflection;
using AirlineModel;
namespace AirlineDL
{
    public class BookingDL
    {
            List<Booking> details = new List<Booking>();

            public BookingDL()
            {
                CreateDetails();
            }

            private void CreateDetails()
            {
                Booking kings = new Booking { ticketnum = "0001" };
                details.Add(kings);
                Booking kingsman = new Booking { ticketnum = "0002" };
                details.Add(kingsman);
                Booking kingkong = new Booking { ticketnum = "0003" };
                details.Add(kingkong);
                Booking kongkong = new Booking { ticketnum = "0004" };
                details.Add(kongkong);
                Booking kungkung = new Booking { ticketnum = "0005" };
                details.Add(kungkung);
        }

            public Booking GetBookings(string ticketnum)
            {
                Booking foundDetail = new Booking();
                foreach (var king in details)
                {
                    if (king.ticketnum == ticketnum)
                    {
                        foundDetail = king;
                    }
                }
                return foundDetail;
            }
        }
    }


