using AirlineDL;
namespace AirlineBL
{
    public class BookingBL
    {
        public bool VerifyBookings(string ticketnum, string userrname)
        {
            bool yoo = new bool();
            BookingDL dataService = new BookingDL();
            var result = dataService.GetBookings(ticketnum);

            if (result.ticketnum != null)
            {
                yoo = true;
            }
            else
            {
                yoo = false;
            }
            return yoo;
        }
    }
}
