using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BookShelf.UC
{
    partial class UCDelete
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
            this.label2 = new System.Windows.Forms.Label();
            this.ausgabe_label = new System.Windows.Forms.Label();
            this.buch_delete_label = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(226)))), ((int)(((byte)(219)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(725, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "löschen.";
            // 
            // ausgabe_label
            // 
            this.ausgabe_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausgabe_label.Location = new System.Drawing.Point(352, 220);
            this.ausgabe_label.Name = "ausgabe_label";
            this.ausgabe_label.Size = new System.Drawing.Size(358, 42);
            this.ausgabe_label.TabIndex = 8;
            // 
            // buch_delete_label
            // 
            this.buch_delete_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(226)))), ((int)(((byte)(219)))));
            this.buch_delete_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buch_delete_label.Location = new System.Drawing.Point(352, 79);
            this.buch_delete_label.Name = "buch_delete_label";
            this.buch_delete_label.Size = new System.Drawing.Size(355, 104);
            this.buch_delete_label.TabIndex = 7;
            this.buch_delete_label.Text = "\r\n\r\nDas Buch, welches gelöscht werden soll, bitte in der Tabelle anklicken.";
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(212)))), ((int)(((byte)(200)))));
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(1156, 322);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(152, 43);
            this.delete_button.TabIndex = 6;
            this.delete_button.Text = "Ausführen";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            this.delete_button.FlatStyle = FlatStyle.Flat;
            this.delete_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(136, 150, 150);
            this.delete_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 116, 112);
            // 
            // UCDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(226)))), ((int)(((byte)(219)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ausgabe_label);
            this.Controls.Add(this.buch_delete_label);
            this.Controls.Add(this.delete_button);
            this.Name = "UCDelete";
            this.Size = new System.Drawing.Size(1362, 419);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ausgabe_label;
        private System.Windows.Forms.Label buch_delete_label;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Label Buch_loeschen_label;

        #endregion
    }
}