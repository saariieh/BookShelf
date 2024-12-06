using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BookShelf.UC
{
    partial class UCInsert
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
            this.insert_button = new System.Windows.Forms.Button();
            this.seitenzahl_label = new System.Windows.Forms.Label();
            this.verlag_label = new System.Windows.Forms.Label();
            this.genre_label = new System.Windows.Forms.Label();
            this.titel_label = new System.Windows.Forms.Label();
            this.autor_label = new System.Windows.Forms.Label();
            this.isbn_label = new System.Windows.Forms.Label();
            this.seitenzahl_box = new System.Windows.Forms.TextBox();
            this.verlag_box = new System.Windows.Forms.TextBox();
            this.autor_box = new System.Windows.Forms.TextBox();
            this.genre_box = new System.Windows.Forms.TextBox();
            this.titel_box = new System.Windows.Forms.TextBox();
            this.isbn_box = new System.Windows.Forms.TextBox();
            this.insert_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // insert_button
            // 
            this.insert_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(212)))), ((int)(((byte)(200)))));
            this.insert_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_button.Location = new System.Drawing.Point(1156, 322);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(152, 43);
            this.insert_button.TabIndex = 17;
            this.insert_button.Text = "Ausführen";
            this.insert_button.UseVisualStyleBackColor = false;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            this.insert_button.FlatStyle = FlatStyle.Flat;
            this.insert_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(136, 150, 150);
            this.insert_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 116, 112);
            // 
            // seitenzahl_label
            // 
            this.seitenzahl_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seitenzahl_label.Location = new System.Drawing.Point(812, 191);
            this.seitenzahl_label.Name = "seitenzahl_label";
            this.seitenzahl_label.Size = new System.Drawing.Size(91, 31);
            this.seitenzahl_label.TabIndex = 13;
            this.seitenzahl_label.Text = "Seitenzahl";
            // 
            // verlag_label
            // 
            this.verlag_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verlag_label.Location = new System.Drawing.Point(452, 195);
            this.verlag_label.Name = "verlag_label";
            this.verlag_label.Size = new System.Drawing.Size(76, 31);
            this.verlag_label.TabIndex = 12;
            this.verlag_label.Text = "Verlag";
            // 
            // genre_label
            // 
            this.genre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre_label.Location = new System.Drawing.Point(812, 64);
            this.genre_label.Name = "genre_label";
            this.genre_label.Size = new System.Drawing.Size(76, 31);
            this.genre_label.TabIndex = 11;
            this.genre_label.Text = "Genre";
            // 
            // titel_label
            // 
            this.titel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel_label.Location = new System.Drawing.Point(110, 195);
            this.titel_label.Name = "titel_label";
            this.titel_label.Size = new System.Drawing.Size(76, 31);
            this.titel_label.TabIndex = 16;
            this.titel_label.Text = "Titel";
            // 
            // autor_label
            // 
            this.autor_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autor_label.Location = new System.Drawing.Point(452, 64);
            this.autor_label.Name = "autor_label";
            this.autor_label.Size = new System.Drawing.Size(76, 31);
            this.autor_label.TabIndex = 15;
            this.autor_label.Text = "Autor";
            // 
            // isbn_label
            // 
            this.isbn_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbn_label.Location = new System.Drawing.Point(110, 64);
            this.isbn_label.Name = "isbn_label";
            this.isbn_label.Size = new System.Drawing.Size(76, 31);
            this.isbn_label.TabIndex = 14;
            this.isbn_label.Text = "ISBN";
            // 
            // seitenzahl_box
            // 
            this.seitenzahl_box.Location = new System.Drawing.Point(812, 225);
            this.seitenzahl_box.Name = "seitenzahl_box";
            this.seitenzahl_box.Size = new System.Drawing.Size(235, 20);
            this.seitenzahl_box.TabIndex = 7;
            // 
            // verlag_box
            // 
            this.verlag_box.Location = new System.Drawing.Point(452, 225);
            this.verlag_box.Name = "verlag_box";
            this.verlag_box.Size = new System.Drawing.Size(235, 20);
            this.verlag_box.TabIndex = 6;
            // 
            // autor_box
            // 
            this.autor_box.Location = new System.Drawing.Point(452, 98);
            this.autor_box.Name = "autor_box";
            this.autor_box.Size = new System.Drawing.Size(235, 20);
            this.autor_box.TabIndex = 5;
            // 
            // genre_box
            // 
            this.genre_box.Location = new System.Drawing.Point(812, 98);
            this.genre_box.Name = "genre_box";
            this.genre_box.Size = new System.Drawing.Size(235, 20);
            this.genre_box.TabIndex = 10;
            // 
            // titel_box
            // 
            this.titel_box.Location = new System.Drawing.Point(110, 225);
            this.titel_box.Name = "titel_box";
            this.titel_box.Size = new System.Drawing.Size(235, 20);
            this.titel_box.TabIndex = 9;
            // 
            // isbn_box
            // 
            this.isbn_box.Location = new System.Drawing.Point(110, 98);
            this.isbn_box.Name = "isbn_box";
            this.isbn_box.Size = new System.Drawing.Size(235, 20);
            this.isbn_box.TabIndex = 8;
            // 
            // insert_label
            // 
            this.insert_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_label.Location = new System.Drawing.Point(-1, 0);
            this.insert_label.Name = "insert_label";
            this.insert_label.Size = new System.Drawing.Size(172, 69);
            this.insert_label.TabIndex = 4;
            this.insert_label.Text = "Buch hinzufügen";
            // 
            // UCInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(226)))), ((int)(((byte)(219)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.seitenzahl_label);
            this.Controls.Add(this.verlag_label);
            this.Controls.Add(this.genre_label);
            this.Controls.Add(this.titel_label);
            this.Controls.Add(this.autor_label);
            this.Controls.Add(this.isbn_label);
            this.Controls.Add(this.seitenzahl_box);
            this.Controls.Add(this.verlag_box);
            this.Controls.Add(this.autor_box);
            this.Controls.Add(this.genre_box);
            this.Controls.Add(this.titel_box);
            this.Controls.Add(this.isbn_box);
            this.Controls.Add(this.insert_label);
            this.Name = "UCInsert";
            this.Size = new System.Drawing.Size(1362, 419);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Label seitenzahl_label;
        private System.Windows.Forms.Label verlag_label;
        private System.Windows.Forms.Label genre_label;
        private System.Windows.Forms.Label titel_label;
        private System.Windows.Forms.Label autor_label;
        private System.Windows.Forms.Label isbn_label;
        private System.Windows.Forms.TextBox seitenzahl_box;
        private System.Windows.Forms.TextBox verlag_box;
        private System.Windows.Forms.TextBox autor_box;
        private System.Windows.Forms.TextBox genre_box;
        private System.Windows.Forms.TextBox titel_box;
        private System.Windows.Forms.TextBox isbn_box;
        private System.Windows.Forms.Label insert_label;

        #endregion
    }
}