using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BookShelf.UC
{
    partial class UCMainDB
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_panel1 = new System.Windows.Forms.Panel();
            this.filter_button = new System.Windows.Forms.Button();
            this.insert_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.meine_buecher_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(226)))), ((int)(((byte)(219)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(213, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(898, 363);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // db_panel1
            // 
            this.db_panel1.Location = new System.Drawing.Point(3, 372);
            this.db_panel1.Name = "db_panel1";
            this.db_panel1.Size = new System.Drawing.Size(1362, 419);
            this.db_panel1.TabIndex = 1;
            // 
            // filter_button
            // 
            this.filter_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(212)))), ((int)(((byte)(200)))));
            this.filter_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(112)))));
            this.filter_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.filter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_button.Location = new System.Drawing.Point(1175, 32);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(152, 43);
            this.filter_button.TabIndex = 2;
            this.filter_button.Text = "Filtern";
            this.filter_button.UseVisualStyleBackColor = false;
            this.filter_button.Click += new System.EventHandler(this.filter_button_Click);
            // 
            // insert_button
            // 
            this.insert_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(212)))), ((int)(((byte)(200)))));
            this.insert_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(112)))));
            this.insert_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.insert_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_button.Location = new System.Drawing.Point(1175, 125);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(152, 43);
            this.insert_button.TabIndex = 3;
            this.insert_button.Text = "Hinzufügen";
            this.insert_button.UseVisualStyleBackColor = false;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(212)))), ((int)(((byte)(200)))));
            this.update_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(112)))));
            this.update_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(1175, 220);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(152, 43);
            this.update_button.TabIndex = 4;
            this.update_button.Text = "Bearbeiten";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(212)))), ((int)(((byte)(200)))));
            this.delete_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(112)))));
            this.delete_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(1175, 309);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(152, 43);
            this.delete_button.TabIndex = 5;
            this.delete_button.Text = "Löschen";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // meine_buecher_label
            // 
            this.meine_buecher_label.BackColor = System.Drawing.Color.Transparent;
            this.meine_buecher_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meine_buecher_label.ForeColor = System.Drawing.Color.Black;
            this.meine_buecher_label.Location = new System.Drawing.Point(13, 14);
            this.meine_buecher_label.Name = "meine_buecher_label";
            this.meine_buecher_label.Size = new System.Drawing.Size(185, 139);
            this.meine_buecher_label.TabIndex = 6;
            this.meine_buecher_label.Text = " Meine Bücher";
            // 
            // UCMainDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(226)))), ((int)(((byte)(219)))));
            this.Controls.Add(this.meine_buecher_label);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.filter_button);
            this.Controls.Add(this.db_panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UCMainDB";
            this.Size = new System.Drawing.Size(1381, 796);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel db_panel1;

        private System.Windows.Forms.Label meine_buecher_label;

        private System.Windows.Forms.Button delete_button;

        private System.Windows.Forms.Button update_button;

        private System.Windows.Forms.Button insert_button;

        private System.Windows.Forms.Button filter_button;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}