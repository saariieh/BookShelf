using System;
using System.Windows.Forms;

namespace BookShelf.UC
{
    public partial class UCUpdate : UserControl
    {
        public static TextBox isbn;
        public static TextBox autor;
        public static TextBox titel;
        public static TextBox verlag;
        public static TextBox genre;
        public static TextBox seitenzahl;
        public UCUpdate()
        {
            InitializeComponent();
            isbn = isbn_box;
            autor = autor_box;
            titel = titel_box;
            verlag = verlag_box;
            genre = genre_box;
            seitenzahl = seitenzahl_box;
            
            UCMainDB.RegisterEvent(Write_textbox);
        }
        public static void Write_textbox()
        {
            isbn.Text = GlobalVariable.clickedISBN;
            autor.Text = GlobalVariable.clickedAutor;
            titel.Text = GlobalVariable.clickedTitel;
            verlag.Text = GlobalVariable.clickedVerlag;
            genre.Text = GlobalVariable.clickedGenre;
            seitenzahl.Text = GlobalVariable.clickedSeitenzahl;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            GlobalVariable.clickedISBN = isbn.Text;
            GlobalVariable.clickedAutor = autor.Text;
            GlobalVariable.clickedTitel = titel.Text;
            GlobalVariable.clickedVerlag = verlag.Text;
            GlobalVariable.clickedGenre = genre.Text;
            GlobalVariable.clickedSeitenzahl = seitenzahl.Text;
            DB.Book_DB.Update_Buch();
            MainForm.instance.LoadUserControl(new UCMainDB());
        }
    }
}