using AirlineBL;
using AirlineDL;
using AirlineModel;
namespace AirlineCheck
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("TONSAY AIRLINES!");

            Console.WriteLine("Enter your Ticket Number:");
            string ticketnum = Console.ReadLine();
            Console.WriteLine("_______________________________________");
            

            BookingBL details = new BookingBL();
            bool result = details.VerifyBookings(ticketnum);


            if (result)
            {
                Console.WriteLine("USER FOUND");
                Console.WriteLine("________________________________________");
                Console.WriteLine("Booking Details");
                    InfoBL service = new InfoBL();
                    Info passenger = service.GetBookingInfo();
                Console.WriteLine("Ticket Number: 0001");
                Console.WriteLine($"Passenger: {passenger.passenger}");
                Console.WriteLine($"Type of Class: {passenger.classtype}");
                Console.WriteLine($"Seat Number: {passenger.seatnum}");
                Console.WriteLine($"Origin: {passenger.origin}");
                Console.WriteLine($"Destination: {passenger.destination}");
                Console.WriteLine($"Date of Flight: {passenger.flightdate}");
                Console.WriteLine("________________________________________");

                    Info passenger2 = service.GetInfo();
                Console.WriteLine("Ticket Number: 0002");
                Console.WriteLine($"Passenger: {passenger2.passenger}");
                Console.WriteLine($"Type of Class: {passenger2.classtype}");
                Console.WriteLine($"Seat Number: {passenger2.seatnum}");
                Console.WriteLine($"Origin: {passenger2.origin}");
                Console.WriteLine($"Destination: {passenger2.destination}");
                Console.WriteLine($"Date of Flight: {passenger2.flightdate}");
                Console.WriteLine("________________________________________");

                    Info passenger3 = service.GetIdea();
                Console.WriteLine("Ticket Number: 0003");
                Console.WriteLine($"Passenger: {passenger3.passenger}");
                Console.WriteLine($"Type of Class: {passenger3.classtype}");
                Console.WriteLine($"Seat Number: {passenger3.seatnum}");
                Console.WriteLine($"Origin: {passenger3.origin}");
                Console.WriteLine($"Destination: {passenger3.destination}");
                Console.WriteLine($"Date of Flight: {passenger3.flightdate}");
                Console.WriteLine("________________________________________");

                Info passenger4 = service.GetIwan();
                Console.WriteLine("Ticket Number: 0004");
                Console.WriteLine($"Passenger: {passenger4.passenger}");
                Console.WriteLine($"Type of Class: {passenger4.classtype}");
                Console.WriteLine($"Seat Number: {passenger4.seatnum}");
                Console.WriteLine($"Origin: {passenger4.origin}");
                Console.WriteLine($"Destination: {passenger4.destination}");
                Console.WriteLine($"Date of Flight: {passenger4.flightdate}");
                Console.WriteLine("________________________________________");

                Info passenger5 = service.GetIda();
                Console.WriteLine("Ticket Number: 0005");
                Console.WriteLine($"Passenger: {passenger5.passenger}");
                Console.WriteLine($"Type of Class: {passenger5.classtype}");
                Console.WriteLine($"Seat Number: {passenger5.seatnum}");
                Console.WriteLine($"Origin: {passenger5.origin}");
                Console.WriteLine($"Destination: {passenger5.destination}");
                Console.WriteLine($"Date of Flight: {passenger5.flightdate}");
                Console.WriteLine("________________________________________");
            }
            else
            {
                Console.WriteLine("USER IS NOT IDENTIFIED");
            }
        }
    }
}








