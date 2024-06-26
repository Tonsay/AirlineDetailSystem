using AirlineModel;
using Microsoft.Data.SqlClient;

namespace AirlineDL
{
    public class SqlDBInfo
    {
        static string connectionString
            = "Data Source = PEARL-LAPTOP//SQLEXPRESS; Initial Catalog = AirlineCheckk; Integrated Security =True;";

        static SqlConnection SqlConnection = new SqlConnection(connectionString);

        public static void Connect()
        {
            SqlConnection.Open();
        }

        public static List<Booking> GetInfo()
        {
            string selectStatement = "SELECT passenger, seat number FROM info";

            SqlCommand selectCommand = new SqlCommand(selectStatement, SqlConnection);

            SqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            List<Booking> infos = new List<Booking>();

            while (reader.Read())
            {
                string passenger = reader["passenger"].ToString();
                string ticketnum = reader["ticketnum"].ToString();


                Booking readInfo = new Booking();
                readInfo.passenger = passenger;
                readInfo.ticketnum = ticketnum;

                infos.Add(readInfo);

            }

            SqlConnection.Close();

            return infos;
        }
        public static int AddInfo(string passenger, string ticketnum)
        {
            int success;

            string insertStatement = "INSERT INTO info VALUES (@passenger, @ticketnum)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, SqlConnection);
            SqlConnection.Open();

            insertCommand.Parameters.AddWithValue("@passenger", passenger);
            insertCommand.Parameters.AddWithValue("@ticketnum", ticketnum);
            
            success = insertCommand.ExecuteNonQuery();

            SqlConnection.Close();

            return success;

        }
        public static void UpdateInfo(string passenger,string ticketnum)
        {
            var updateStatement = $"UPDATE info SET ticketnum = @ticketnum WHERE ticketnum = @ticketnum )";

            SqlCommand updateCommand = new SqlCommand(updateStatement, SqlConnection);
            SqlConnection.Open();

            updateCommand.Parameters.AddWithValue("@passenger", passenger);
            updateCommand.Parameters.AddWithValue("@ticketnum", ticketnum);


            updateCommand.ExecuteNonQuery();

            SqlConnection.Close();

        }

        public static void DeleteInfo(string ticketnum)
        {
            string deleteStatement = $"DELETE FROM info WHERE ticketnum = @ticketnum";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, SqlConnection);
            SqlConnection.Open();

            deleteCommand.Parameters.AddWithValue("@ticketnum", ticketnum);

            deleteCommand.ExecuteNonQuery();

            SqlConnection.Close();
        }

    }
}

 