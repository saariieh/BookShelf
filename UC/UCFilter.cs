using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BookShelf.UC
{
    public partial class UCFilter : UserControl
    {
        public UCFilter()
        {
            InitializeComponent();
        }

        private void filtern_button_Click(object sender, EventArgs e)
        {
            string suche = richTextBox1.Text;
            DataSet filter = null;
            if (isbn_radiobutton.Checked == true)
            {
                filter = DB.Book_DB.Anzeige_ISBN_Buch(suche);
            }
            else if (autor_radioButton.Checked == true)
            {
                filter = DB.Book_DB.Anzeige_Autor_Buch(suche);
            }
            else if (titel_radioButton.Checked == true)
            {
                filter = DB.Book_DB.Anzeige_Titel_Buch(suche);
            }
            else if (verlag_radioButton.Checked == true)
            {
                filter = DB.Book_DB.Anzeige_Verlag_Buch(suche);
            }
            else if (genre_radioButton.Checked == true)
            {
                filter = DB.Book_DB.Anzeige_Genre_Buch(suche);
            }

            if (filter != null)
            {
              dataGridViewFilter.DataSource = filter.Tables[0];
              DataGridFilter_Design();
            }
                
        }
        
        private void DataGridFilter_Design()
        {
            dataGridViewFilter.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFilter.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFilter.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFilter.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFilter.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFilter.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFilter.Columns[dataGridViewFilter.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            dataGridViewFilter.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewFilter.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            
        }
        
    }
}    