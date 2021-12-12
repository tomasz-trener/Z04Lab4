using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02WygodnaKlasa
{
    class PolaczenieZBaza
    {
        public string[][] WykonajPolecenieSQL(string connString, string polecenieSQL)
        {
            SqlConnection connection; // służy do komunikacji z baza danych 
            SqlCommand command; // przechowuje polecenia SQL
            SqlDataReader dataReader; // służy do czytania danych z bazy 

            connection = new SqlConnection(connString);

            command = new SqlCommand(polecenieSQL, connection);
            connection.Open();

            dataReader = command.ExecuteReader(); // wysyłamy polecenie sql do bazy 

            List<string[]> listaWierszy = new List<string[]>();

            while (dataReader.Read())
            {
                string[] komorki = new string[dataReader.FieldCount];
                for (int i = 0; i < dataReader.FieldCount; i++)
                    komorki[i] = Convert.ToString(dataReader.GetValue(i));

                listaWierszy.Add(komorki);
            }
            connection.Close();

            return listaWierszy.ToArray();

        }



    }
}
