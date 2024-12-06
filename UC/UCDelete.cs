using System;
using System.Windows.Forms;

namespace BookShelf.UC
{
    public partial class UCDelete : UserControl
    {
        public static Label label;
        public UCDelete()
        {
            InitializeComponent();
            label = ausgabe_label;
            UCMainDB.RegisterEvent(Write_Label);
        }
        public void Write_Label()
        {
            label.Text = GlobalVariable.clickedTitel;  
         
        }
        

        private void delete_button_Click(object sender, EventArgs e)
        {
            DB.Book_DB.Delete_Buch();
            MainForm.instance.LoadUserControl(new UCMainDB());
        }
    }
}