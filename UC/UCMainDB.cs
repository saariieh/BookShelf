using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BookShelf.DB;

namespace BookShelf.UC
{
    public partial class UCMainDB : UserControl
    {
        private Panel db_panel;
        private DataGrid data;
        private static Action onPanelClick;
        public static UCMainDB instance;
        
        public UCMainDB()
        {
            InitializeComponent();
            db_panel = db_panel1;
            instance = this;
            Connect.Verbinden();
            DataSet dataSet = Book_DB.Anzeige_Alle_Buch();
            if (dataSet != null)
            {
                dataGridView1.DataSource = dataSet.Tables[0];
                DataGrid_Design();

            }
            
            
        }

        private void DataGrid_Design()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            
        }

        public void LoadUserControlDB(UserControl newUC)
        {
            db_panel.Controls.Clear();
            db_panel.Controls.Add(newUC);
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            LoadUserControlDB(new UCInsert());
        }

        private void  delete_button_Click(object sender, EventArgs e)
        {
            LoadUserControlDB(new UCDelete());
            
        }

        private void filter_button_Click(object sender, EventArgs e)
        {
            LoadUserControlDB(new UCFilter());
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            LoadUserControlDB(new UCUpdate());
            
        }
        public virtual void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells["buchid"].Value.ToString();
            string titel = dataGridView1.CurrentRow.Cells["titel"].Value.ToString();
            string isbn = dataGridView1.CurrentRow.Cells["isbn"].Value.ToString();
            string autor = dataGridView1.CurrentRow.Cells["autor"].Value.ToString();
            string verlag = dataGridView1.CurrentRow.Cells["verlag"].Value.ToString();
            string genre = dataGridView1.CurrentRow.Cells["genre"].Value.ToString();
            string seitenzahl = dataGridView1.CurrentRow.Cells["seitenzahl"].Value.ToString();
            
            GlobalVariable.clickedID = id;
            GlobalVariable.clickedISBN = isbn;
            GlobalVariable.clickedTitel = titel;
            GlobalVariable.clickedAutor = autor;
            GlobalVariable.clickedVerlag = verlag;
            GlobalVariable.clickedGenre = genre;
            GlobalVariable.clickedSeitenzahl = seitenzahl;
            
            onPanelClick?.Invoke();
        }

        public static void RegisterEvent(Action a)
        {
            onPanelClick = null;
            onPanelClick += a;
        }
        
        
    }
}