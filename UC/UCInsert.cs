using System;
using System.Windows.Forms;

namespace BookShelf.UC
{
    public partial class UCInsert : UserControl
    {
        public UCInsert()
        {
            InitializeComponent();
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            string isbn = isbn_box.Text;
            string autor = autor_box.Text;
            string titel = titel_box.Text;
            string verlag = verlag_box.Text;
            string genre = genre_box.Text;
            string seitenzahl = seitenzahl_box.Text;

            DB.Book_DB.Hinzufuegen_Buch(isbn, autor, titel, verlag, genre, seitenzahl);
            MainForm.instance.LoadUserControl(new UCMainDB());
            UCMainDB.instance.LoadUserControlDB(new UCInsert());
        }
    }
}