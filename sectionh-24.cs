using System;
using System.Data.SqlClient;
class Program
{
    static void Main()
    {
        string connectionString = @"Server=PSILENL076;Database=csharp;Trusted_Connection=True;";
        string query = "SELECT Id, Name, Marks FROM Students";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            Console.WriteLine("ID\tName\tMarks");
            while (reader.Read())
            {
                Console.WriteLine($"{reader["Id"]}\t{reader["Name"]}\t{reader["Marks"]}");
            }
        }
    }
}
