using System;
using MySql.Data.MySqlClient;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection connection;

            // database login information
            string connectionString = "Server = localhost; User Id = root; Database = Car; Password = root54321"; 
            connection = new MySqlConnection(connectionString); // joins login information to begin connection
            connection.Open(); // opens connection to database
            Console.WriteLine(connection); // not required, just for reading
            Console.WriteLine("---Connected to Database---");

            string name = "Mercedes AMG GT 63s"; // the parameter you want to insert
            string query = "INSERT INTO Car.Zameen_CS(Car_Name) VALUES('" + name + "')"; // the query
            MySqlCommand command = new MySqlCommand(query, connection); // joining login info wiyh query to make a command
            Console.WriteLine(command); // not required, just for reading
            command.ExecuteNonQuery(); // executed the command we have created
            Console.WriteLine("Data has been inserted");
        }
    }
}