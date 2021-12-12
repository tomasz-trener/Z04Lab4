using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02WygodnaKlasa
{
    class Program
    {
        static void Main(string[] args)
        {
            //string connString = "Data Source=mssql4.webio.pl,2401;Initial Catalog=tomasz1_zawodnicy;" +
            // "User ID=tomasz1_zawodnicy;Password=Politechnika1!";

            string connString = "Data Source=localhost\\sqlexpress;Initial Catalog=A_Zawodnicy;Integrated Security=True";

            PolaczenieZBaza pzb = new PolaczenieZBaza();
            string[][] wynik =
                pzb.WykonajPolecenieSQL
                (connString, "select imie_t, nazwisko_t from trenerzy");

            for (int i = 0; i < wynik.Length; i++)
            {
                for (int j = 0; j < wynik[i].Length; j++)
                {
                    Console.Write(wynik[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
