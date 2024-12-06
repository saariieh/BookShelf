using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShelf.UC;
using MaterialSkin.Controls;

namespace BookShelf
{
    public partial class MainForm : MaterialForm
    {
        public static MainForm instance;
        public Panel panel;
        public MainForm()
        {
            InitializeComponent();
            instance = this;
            panel = panel_Container1;
            
            LoadUserControl(new UCMainDB());
        }
        public void LoadUserControl(UserControl newUC)
        {
            panel_Container1.Controls.Clear();
            panel_Container1.Controls.Add(newUC);
        }
    }
}