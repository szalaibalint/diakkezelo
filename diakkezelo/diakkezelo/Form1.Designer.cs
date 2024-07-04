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
            this.lblKivalasztottak = new System.Windows.Forms.Label();
            this.lblLegidosebbek = new System.Windows.Forms.Label();
            this.btnAdatbevitel = new System.Windows.Forms.Button();
            this.btnKivalaszt = new System.Windows.Forms.Button();
            this.pnlDiakok = new System.Windows.Forms.Panel();
            this.lstKivalasztottak = new System.Windows.Forms.ListBox();
            this.lstLegidosebbek = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblDiak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDiakok
            // 
            this.lblDiakok.AutoSize = true;
            this.lblDiakok.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDiakok.ForeColor = System.Drawing.Color.Maroon;
            this.lblDiakok.Location = new System.Drawing.Point(118, 29);
            this.lblDiakok.Name = "lblDiakok";
            this.lblDiakok.Size = new System.Drawing.Size(73, 25);
            this.lblDiakok.TabIndex = 0;
            this.lblDiakok.Text = "Diákok";
            // 
            // lblKivalasztottak
            // 
            this.lblKivalasztottak.AutoSize = true;
            this.lblKivalasztottak.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblKivalasztottak.ForeColor = System.Drawing.Color.Maroon;
            this.lblKivalasztottak.Location = new System.Drawing.Point(355, 29);
            this.lblKivalasztottak.Name = "lblKivalasztottak";
            this.lblKivalasztottak.Size = new System.Drawing.Size(140, 25);
            this.lblKivalasztottak.TabIndex = 1;
            this.lblKivalasztottak.Text = "Kiválasztottak";
            // 
            // lblLegidosebbek
            // 
            this.lblLegidosebbek.AutoSize = true;
            this.lblLegidosebbek.Location = new System.Drawing.Point(314, 230);
            this.lblLegidosebbek.Name = "lblLegidosebbek";
            this.lblLegidosebbek.Size = new System.Drawing.Size(77, 13);
            this.lblLegidosebbek.TabIndex = 2;
            this.lblLegidosebbek.Text = "Legidősebbek:";
            // 
            // btnAdatbevitel
            // 
            this.btnAdatbevitel.Location = new System.Drawing.Point(44, 352);
            this.btnAdatbevitel.Name = "btnAdatbevitel";
            this.btnAdatbevitel.Size = new System.Drawing.Size(75, 23);
            this.btnAdatbevitel.TabIndex = 3;
            this.btnAdatbevitel.Text = "Adatbevitel";
            this.btnAdatbevitel.UseVisualStyleBackColor = true;
            this.btnAdatbevitel.Click += new System.EventHandler(this.btnAdatbevitel_Click);
            // 
            // btnKivalaszt
            // 
            this.btnKivalaszt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKivalaszt.Location = new System.Drawing.Point(195, 352);
            this.btnKivalaszt.Name = "btnKivalaszt";
            this.btnKivalaszt.Size = new System.Drawing.Size(75, 23);
            this.btnKivalaszt.TabIndex = 4;
            this.btnKivalaszt.Text = "Kiválasztás";
            this.btnKivalaszt.UseVisualStyleBackColor = true;
            this.btnKivalaszt.Click += new System.EventHandler(this.btnKivalaszt_Click);
            // 
            // pnlDiakok
            // 
            this.pnlDiakok.AutoScroll = true;
            this.pnlDiakok.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlDiakok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDiakok.Location = new System.Drawing.Point(44, 63);
            this.pnlDiakok.Name = "pnlDiakok";
            this.pnlDiakok.Size = new System.Drawing.Size(226, 272);
            this.pnlDiakok.TabIndex = 5;
            // 
            // lstKivalasztottak
            // 
            this.lstKivalasztottak.FormattingEnabled = true;
            this.lstKivalasztottak.Location = new System.Drawing.Point(311, 63);
            this.lstKivalasztottak.Name = "lstKivalasztottak";
            this.lstKivalasztottak.Size = new System.Drawing.Size(226, 147);
            this.lstKivalasztottak.TabIndex = 6;
            this.lstKivalasztottak.SelectedIndexChanged += new System.EventHandler(this.lstKivalasztottak_SelectedIndexChanged);
            // 
            // lstLegidosebbek
            // 
            this.lstLegidosebbek.FormattingEnabled = true;
            this.lstLegidosebbek.Location = new System.Drawing.Point(311, 253);
            this.lstLegidosebbek.Name = "lstLegidosebbek";
            this.lstLegidosebbek.Size = new System.Drawing.Size(226, 82);
            this.lstLegidosebbek.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblDiak
            // 
            this.lblDiak.AutoSize = true;
            this.lblDiak.Location = new System.Drawing.Point(308, 357);
            this.lblDiak.Name = "lblDiak";
            this.lblDiak.Size = new System.Drawing.Size(0, 13);
            this.lblDiak.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(580, 400);
            this.Controls.Add(this.lstKivalasztottak);
            this.Controls.Add(this.lblDiak);
            this.Controls.Add(this.lstLegidosebbek);
            this.Controls.Add(this.pnlDiakok);
            this.Controls.Add(this.btnKivalaszt);
            this.Controls.Add(this.btnAdatbevitel);
            this.Controls.Add(this.lblLegidosebbek);
            this.Controls.Add(this.lblKivalasztottak);
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
        private System.Windows.Forms.Label lblKivalasztottak;
        private System.Windows.Forms.Label lblLegidosebbek;
        private System.Windows.Forms.Button btnAdatbevitel;
        private System.Windows.Forms.Button btnKivalaszt;
        private System.Windows.Forms.Panel pnlDiakok;
        private System.Windows.Forms.ListBox lstKivalasztottak;
        private System.Windows.Forms.ListBox lstLegidosebbek;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblDiak;
    }
}

