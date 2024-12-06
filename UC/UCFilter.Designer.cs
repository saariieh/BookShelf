using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BookShelf.UC
{
    partial class UCFilter
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
            this.dataGridViewFilter = new System.Windows.Forms.DataGridView();
            this.genre_radioButton = new System.Windows.Forms.RadioButton();
            this.verlag_radioButton = new System.Windows.Forms.RadioButton();
            this.titel_radioButton = new System.Windows.Forms.RadioButton();
            this.autor_radioButton = new System.Windows.Forms.RadioButton();
            this.isbn_radiobutton = new System.Windows.Forms.RadioButton();
            this.filtern_button = new System.Windows.Forms.Button();
            this.nach_buch_filtern = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.such_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFilter
            // 
            this.dataGridViewFilter.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilter.Location = new System.Drawing.Point(375, 87);
            this.dataGridViewFilter.Name = "dataGridViewFilter";
            this.dataGridViewFilter.Size = new System.Drawing.Size(898, 179);
            this.dataGridViewFilter.TabIndex = 13;
            // 
            // genre_radioButton
            // 
            this.genre_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre_radioButton.Location = new System.Drawing.Point(106, 317);
            this.genre_radioButton.Name = "genre_radioButton";
            this.genre_radioButton.Size = new System.Drawing.Size(173, 53);
            this.genre_radioButton.TabIndex = 10;
            this.genre_radioButton.TabStop = true;
            this.genre_radioButton.Text = "Genre";
            this.genre_radioButton.UseVisualStyleBackColor = true;
            // 
            // verlag_radioButton
            // 
            this.verlag_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verlag_radioButton.Location = new System.Drawing.Point(106, 256);
            this.verlag_radioButton.Name = "verlag_radioButton";
            this.verlag_radioButton.Size = new System.Drawing.Size(173, 53);
            this.verlag_radioButton.TabIndex = 11;
            this.verlag_radioButton.TabStop = true;
            this.verlag_radioButton.Text = "Verlag";
            this.verlag_radioButton.UseVisualStyleBackColor = true;
            // 
            // titel_radioButton
            // 
            this.titel_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel_radioButton.Location = new System.Drawing.Point(106, 197);
            this.titel_radioButton.Name = "titel_radioButton";
            this.titel_radioButton.Size = new System.Drawing.Size(173, 53);
            this.titel_radioButton.TabIndex = 9;
            this.titel_radioButton.TabStop = true;
            this.titel_radioButton.Text = "Titel";
            this.titel_radioButton.UseVisualStyleBackColor = true;
            // 
            // autor_radioButton
            // 
            this.autor_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autor_radioButton.Location = new System.Drawing.Point(106, 138);
            this.autor_radioButton.Name = "autor_radioButton";
            this.autor_radioButton.Size = new System.Drawing.Size(173, 53);
            this.autor_radioButton.TabIndex = 7;
            this.autor_radioButton.TabStop = true;
            this.autor_radioButton.Text = "Autor";
            this.autor_radioButton.UseVisualStyleBackColor = true;
            // 
            // isbn_radiobutton
            // 
            this.isbn_radiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbn_radiobutton.Location = new System.Drawing.Point(106, 76);
            this.isbn_radiobutton.Name = "isbn_radiobutton";
            this.isbn_radiobutton.Size = new System.Drawing.Size(175, 56);
            this.isbn_radiobutton.TabIndex = 8;
            this.isbn_radiobutton.TabStop = true;
            this.isbn_radiobutton.Text = "ISBN";
            this.isbn_radiobutton.UseVisualStyleBackColor = true;
            // 
            // filtern_button
            // 
            this.filtern_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(212)))), ((int)(((byte)(200)))));
            this.filtern_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtern_button.Location = new System.Drawing.Point(1156, 322);
            this.filtern_button.Name = "filtern_button";
            this.filtern_button.Size = new System.Drawing.Size(152, 43);
            this.filtern_button.TabIndex = 6;
            this.filtern_button.Text = "Ausführen";
            this.filtern_button.UseVisualStyleBackColor = false;
            this.filtern_button.Click += new System.EventHandler(this.filtern_button_Click);
            this.filtern_button.FlatStyle = FlatStyle.Flat;
            this.filtern_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(136, 150, 150);
            this.filtern_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 116, 112);
            // 
            // nach_buch_filtern
            // 
            this.nach_buch_filtern.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nach_buch_filtern.Location = new System.Drawing.Point(25, 14);
            this.nach_buch_filtern.Name = "nach_buch_filtern";
            this.nach_buch_filtern.Size = new System.Drawing.Size(288, 39);
            this.nach_buch_filtern.TabIndex = 5;
            this.nach_buch_filtern.Text = "Nach Buch filtern";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(795, 324);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(307, 42);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // such_label
            // 
            this.such_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.such_label.Location = new System.Drawing.Point(795, 295);
            this.such_label.Name = "such_label";
            this.such_label.Size = new System.Drawing.Size(165, 26);
            this.such_label.TabIndex = 15;
            this.such_label.Text = "Suchbegriff\r\n";
            // 
            // UCFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(226)))), ((int)(((byte)(219)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.such_label);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridViewFilter);
            this.Controls.Add(this.genre_radioButton);
            this.Controls.Add(this.verlag_radioButton);
            this.Controls.Add(this.titel_radioButton);
            this.Controls.Add(this.autor_radioButton);
            this.Controls.Add(this.isbn_radiobutton);
            this.Controls.Add(this.filtern_button);
            this.Controls.Add(this.nach_buch_filtern);
            this.Name = "UCFilter";
            this.Size = new System.Drawing.Size(1362, 419);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilter)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label such_label;

        private System.Windows.Forms.RichTextBox richTextBox1;

        private System.Windows.Forms.DataGridView dataGridViewFilter;
        private System.Windows.Forms.RadioButton genre_radioButton;
        private System.Windows.Forms.RadioButton verlag_radioButton;
        private System.Windows.Forms.RadioButton titel_radioButton;
        private System.Windows.Forms.RadioButton autor_radioButton;
        private System.Windows.Forms.RadioButton isbn_radiobutton;
        private System.Windows.Forms.Button filtern_button;
        private System.Windows.Forms.Label nach_buch_filtern;

        #endregion
    }
}