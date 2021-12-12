using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01PolaczenieZBaza
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection; // służy do komunikacji z baza danych 
            SqlCommand command; // przechowuje polecenia SQL
            SqlDataReader dataReader; // służy do czytania danych z bazy 

            string connString = "Data Source=mssql4.webio.pl,2401;Initial Catalog=tomasz1_zawodnicy;" +
              "User ID=tomasz1_zawodnicy;Password=Politechnika1!";

            connection = new SqlConnection(connString);

            command = new SqlCommand("SELECT * FROM zawodnicy",connection);
            connection.Open();

            dataReader = command.ExecuteReader(); // wysyłamy polecenie sql do bazy 

            while (dataReader.Read())
            {
                string wynik = Convert.ToString(dataReader.GetValue(2) + " " + dataReader.GetValue(3));
                Console.WriteLine(wynik);
            }


            connection.Close();

            Console.ReadKey();


        }
    }
}
