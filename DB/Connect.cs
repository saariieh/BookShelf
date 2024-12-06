using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace BookShelf.DB
{
    public class Connect
    {
        public static string verbindungsstring =
            "datasource=127.0.0.1;port=3306;username=root;password=;database=bookshelf;";

        public static MySqlConnection connection = null;
        public static MySqlCommand command = null;
        public static DataSet dataset;
        public static MySqlDataAdapter adapter;

        //Verbinden
        public static void Verbinden()
        {
            try
            {
                connection = new MySqlConnection(verbindungsstring);
                connection.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void Verbindung_trennen()
        {
            try
            {
                connection = new MySqlConnection(verbindungsstring);
                connection.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}    
    