namespace diakkezelo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDiakok = new System.Windows.Forms.Label();
            this.lblSzuletesiEv = new System.Windows.Forms.Label();
            this.lblKeresesEredmenye = new System.Windows.Forms.Label();
            this.btnAdatbevitel = new System.Windows.Forms.Button();
            this.lstEredmeny = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblDiak = new System.Windows.Forms.Label();
            this.pnlEvek = new System.Windows.Forms.Panel();
            this.lstDiakok = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblDiakok
            // 
            this.lblDiakok.AutoSize = true;
            this.lblDiakok.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDiakok.ForeColor = System.Drawing.Color.Maroon;
            this.lblDiakok.Location = new System.Drawing.Point(80, 29);
            this.lblDiakok.Name = "lblDiakok";
            this.lblDiakok.Size = new System.Drawing.Size(73, 25);
            this.lblDiakok.TabIndex = 0;
            this.lblDiakok.Text = "Diákok";
            // 
            // lblSzuletesiEv
            // 
            this.lblSzuletesiEv.AutoSize = true;
            this.lblSzuletesiEv.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSzuletesiEv.ForeColor = System.Drawing.Color.Maroon;
            this.lblSzuletesiEv.Location = new System.Drawing.Point(343, 29);
            this.lblSzuletesiEv.Name = "lblSzuletesiEv";
            this.lblSzuletesiEv.Size = new System.Drawing.Size(112, 25);
            this.lblSzuletesiEv.TabIndex = 1;
            this.lblSzuletesiEv.Text = "Születési év";
            // 
            // lblKeresesEredmenye
            // 
            this.lblKeresesEredmenye.AutoSize = true;
            this.lblKeresesEredmenye.Location = new System.Drawing.Point(248, 138);
            this.lblKeresesEredmenye.Name = "lblKeresesEredmenye";
            this.lblKeresesEredmenye.Size = new System.Drawing.Size(112, 13);
            this.lblKeresesEredmenye.TabIndex = 2;
            this.lblKeresesEredmenye.Text = "A keresés eredménye:";
            // 
            // btnAdatbevitel
            // 
            this.btnAdatbevitel.Location = new System.Drawing.Point(81, 350);
            this.btnAdatbevitel.Name = "btnAdatbevitel";
            this.btnAdatbevitel.Size = new System.Drawing.Size(75, 23);
            this.btnAdatbevitel.TabIndex = 3;
            this.btnAdatbevitel.Text = "Adatbevitel";
            this.btnAdatbevitel.UseVisualStyleBackColor = true;
            this.btnAdatbevitel.Click += new System.EventHandler(this.btnAdatbevitel_Click);
            // 
            // lstEredmeny
            // 
            this.lstEredmeny.FormattingEnabled = true;
            this.lstEredmeny.Location = new System.Drawing.Point(247, 156);
            this.lstEredmeny.Name = "lstEredmeny";
            this.lstEredmeny.Size = new System.Drawing.Size(304, 173);
            this.lstEredmeny.TabIndex = 7;
            this.lstEredmeny.SelectedIndexChanged += new System.EventHandler(this.lstEredmeny_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblDiak
            // 
            this.lblDiak.AutoSize = true;
            this.lblDiak.Location = new System.Drawing.Point(244, 354);
            this.lblDiak.Name = "lblDiak";
            this.lblDiak.Size = new System.Drawing.Size(0, 13);
            this.lblDiak.TabIndex = 8;
            // 
            // pnlEvek
            // 
            this.pnlEvek.AutoScroll = true;
            this.pnlEvek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEvek.Location = new System.Drawing.Point(247, 65);
            this.pnlEvek.Name = "pnlEvek";
            this.pnlEvek.Size = new System.Drawing.Size(304, 53);
            this.pnlEvek.TabIndex = 9;
            // 
            // lstDiakok
            // 
            this.lstDiakok.FormattingEnabled = true;
            this.lstDiakok.Location = new System.Drawing.Point(30, 65);
            this.lstDiakok.Name = "lstDiakok";
            this.lstDiakok.Size = new System.Drawing.Size(178, 264);
            this.lstDiakok.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(580, 400);
            this.Controls.Add(this.lstDiakok);
            this.Controls.Add(this.pnlEvek);
            this.Controls.Add(this.lblDiak);
            this.Controls.Add(this.lstEredmeny);
            this.Controls.Add(this.btnAdatbevitel);
            this.Controls.Add(this.lblKeresesEredmenye);
            this.Controls.Add(this.lblSzuletesiEv);
            this.Controls.Add(this.lblDiakok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diákok adatai";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiakok;
        private System.Windows.Forms.Label lblSzuletesiEv;
        private System.Windows.Forms.Label lblKeresesEredmenye;
        private System.Windows.Forms.Button btnAdatbevitel;
        private System.Windows.Forms.ListBox lstEredmeny;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblDiak;
        private System.Windows.Forms.Panel pnlEvek;
        private System.Windows.Forms.ListBox lstDiakok;
    }
}

