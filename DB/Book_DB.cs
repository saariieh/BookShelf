using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace BookShelf.DB
{
    public class Book_DB
    {
        public static DataSet Anzeige_Alle_Buch()
        {
            try
            {
                Connect.Verbinden();
                string sql = "CALL Anzeige_alle_Buch";
                Connect.command = new MySqlCommand(sql, Connect.connection);
                
                Connect.adapter = new MySqlDataAdapter(Connect.command);
                Connect.dataset = new DataSet();
                Connect.adapter.Fill(Connect.dataset);
            
                return Connect.dataset;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
               
            }
            finally
            {
                Connect.connection.Close();
            }

            return null;
        }
        
        //Hinzufügen
        public static void Hinzufuegen_Buch(string isbn, string autor, string titel, string verlag, string genre,string seitenzahl)
        {
            try
            {
                Connect.Verbinden();
                string sql = "CALL Insert_Buch(@isbn,@autor,@titel,@verlag,@genre,@seitenzahl)";
                Connect.command = new MySqlCommand(sql, Connect.connection);
                
                Connect.command.Parameters.AddWithValue("@isbn", isbn);
                Connect.command.Parameters.AddWithValue("@autor", autor);
                Connect.command.Parameters.AddWithValue("@titel", titel);
                Connect.command.Parameters.AddWithValue("@verlag", verlag);
                Connect.command.Parameters.AddWithValue("@genre", genre);
                Connect.command.Parameters.AddWithValue("@seitenzahl", seitenzahl);
                Connect.command.ExecuteNonQuery();
                
                //UC.UCMainDB.Data.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
               
            }
            finally
            {
                Connect.connection.Close();
            }
        }
        
       //Filter DB Abfragen (kleiner Table)
       public static DataSet Anzeige_ISBN_Buch(string suche)
       {
           try
           {
               Connect.Verbinden();
               string sql = "CALL Anzeige_ISBN_Buch(@isbn)";
               
               Connect.command = new MySqlCommand(sql, Connect.connection);
               
               Connect.command.Parameters.AddWithValue("@isbn", "%"+suche+"%");
                
               Connect.adapter = new MySqlDataAdapter(Connect.command);
               Connect.dataset = new DataSet();
               Connect.adapter.Fill(Connect.dataset);
            
               return Connect.dataset;
           }
           catch (Exception e)
           {
               Console.WriteLine(e);
               
           }
           finally
           {
               Connect.Verbindung_trennen();
           }

           return null;
       }
       public static DataSet Anzeige_Autor_Buch(string suche)
       {
           try
           {
               Connect.Verbinden();
               string sql = "CALL Anzeige_Autor_Buch(@autor)";
               
               Connect.command = new MySqlCommand(sql, Connect.connection);
               
               Connect.command.Parameters.AddWithValue("@autor", "%"+suche+"%");
                
               Connect.adapter = new MySqlDataAdapter(Connect.command);
               Connect.dataset = new DataSet();
               Connect.adapter.Fill(Connect.dataset);
            
               return Connect.dataset;
           }
           catch (Exception e)
           {
               Console.WriteLine(e);
               
           }
           finally
           {
               Connect.connection.Close();
           }

           return null;
       }
       public static DataSet Anzeige_Titel_Buch(string suche)
       {
           try
           {
               Connect.Verbinden();
               string sql = "CALL Anzeige_Titel_Buch(@titel)";
               
               Connect.command = new MySqlCommand(sql, Connect.connection);
               
               Connect.command.Parameters.AddWithValue("@titel", "%"+suche+"%");
                
               Connect.adapter = new MySqlDataAdapter(Connect.command);
               Connect.dataset = new DataSet();
               Connect.adapter.Fill(Connect.dataset);
            
               return Connect.dataset;
           }
           catch (Exception e)
           {
               Console.WriteLine(e);
               
           }
           finally
           {
               Connect.connection.Close();
           }

           return null;
       }
       public static DataSet Anzeige_Verlag_Buch(string suche)
       {
           try
           {
               Connect.Verbinden();
               string sql = "CALL Anzeige_Verlag_Buch(@verlag)";
               
               Connect.command = new MySqlCommand(sql, Connect.connection);
               
               Connect.command.Parameters.AddWithValue("@verlag", "%"+suche+"%");
                
               Connect.adapter = new MySqlDataAdapter(Connect.command);
               Connect.dataset = new DataSet();
               Connect.adapter.Fill(Connect.dataset);
            
               return Connect.dataset;
           }
           catch (Exception e)
           {
               Console.WriteLine(e);
               
           }
           finally
           {
               Connect.Verbindung_trennen();
           }

           return null;
       }
       public static DataSet Anzeige_Genre_Buch(string suche)
       {
           try
           {
               Connect.Verbinden();
               string sql = "CALL Anzeige_Genre_Buch(@genre)";
               
               Connect.command = new MySqlCommand(sql, Connect.connection);
               
               Connect.command.Parameters.AddWithValue("@genre", "%"+suche+"%");
                
               Connect.adapter = new MySqlDataAdapter(Connect.command);
               Connect.dataset = new DataSet();
               Connect.adapter.Fill(Connect.dataset);
            
               return Connect.dataset;
           }
           catch (Exception e)
           {
               Console.WriteLine(e);
               
           }
           finally
           {
               Connect.Verbindung_trennen();
           }

           return null;
       }
       
       //Löschen
       public static void Delete_Buch()
       {
           try
           {
               Connect.Verbinden();
               string sql = "CALL Delete_ID_Buch(@id)";
               Connect.command = new MySqlCommand(sql, Connect.connection);

               string index = GlobalVariable.clickedID;
               Connect.command.Parameters.AddWithValue("@id", index);
               Connect.command.ExecuteNonQuery();
           }
           catch (MySqlException e)
           {
               MessageBox.Show(e.Message);
               
           }
           finally
           {
               Connect.Verbindung_trennen();
           }
       }
       
       //Update
       public static void Update_Buch()
       {
           try
           {
               Connect.Verbinden();
               string sql = "CALL Update_ID_Buch(@id,@isbn,@autor,@titel,@verlag,@genre,@seitenzahl)";
               Connect.command = new MySqlCommand(sql, Connect.connection);
               
               Connect.command.Parameters.AddWithValue("@id", GlobalVariable.clickedID); 
               Connect.command.Parameters.AddWithValue("@isbn", GlobalVariable.clickedISBN);
               Connect.command.Parameters.AddWithValue("@autor", GlobalVariable.clickedAutor);
               Connect.command.Parameters.AddWithValue("@titel", GlobalVariable.clickedTitel);
               Connect.command.Parameters.AddWithValue("@verlag", GlobalVariable.clickedVerlag);
               Connect.command.Parameters.AddWithValue("@genre", GlobalVariable.clickedGenre);
               Connect.command.Parameters.AddWithValue("@seitenzahl", GlobalVariable.clickedSeitenzahl);
               Connect.command.ExecuteNonQuery();
           }
           catch (MySqlException e)
           {
               Console.WriteLine(e);
               
           }
           finally
           {
               Connect.Verbindung_trennen();
           }
       }
    }
}