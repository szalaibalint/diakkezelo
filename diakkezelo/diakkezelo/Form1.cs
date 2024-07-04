using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diakkezelo
{
    public partial class Form1 : Form
    {
        List<Diak> diakok = new List<Diak>();

        class Diak
        {
            public string Nev { get; private set; }
            public string TanulmanyiKod { get; private set; }
            public int szulEv { get; private set; }

            public Diak(string nev, string tanulmanyiKod, int szulev)
            {
                Nev = nev;
                TanulmanyiKod = tanulmanyiKod;
                szulEv = szulev;
            }

            public override string ToString()
            {
                return Nev + " (" + TanulmanyiKod + ")";
            }
        }

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GombBeallitas(false);
        }

        private void GombBeallitas(bool aktiv)
        {
            btnAdatbevitel.Enabled = !aktiv;
            btnKivalaszt.Enabled = aktiv;
        }

        private void AdatBevitel()
        {
            DialogResult eredmeny = openFileDialog1.ShowDialog();
            if (eredmeny == DialogResult.OK)
            {
                string fajlNev = openFileDialog1.FileName;
                try
                {
                    AdatBeolvasas(fajlNev);
                    FelrakDiakok();
                    GombBeallitas(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a fájl beolvasásakor", "Hiba");
                }
            }
        }

        private void AdatBeolvasas(string fajlNev)
        {
            StreamReader olvasoCsatorna = null;
            try
            {
                olvasoCsatorna = new StreamReader(fajlNev);
                while (!olvasoCsatorna.EndOfStream)
                {
                    string adat = olvasoCsatorna.ReadLine();
                    Feldolgoz(adat);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba a fájl beolvasásánál", "Hiba");
            }
            olvasoCsatorna.Close();
        }

        private void Feldolgoz(string adat)
        {
            string[] adatok = adat.Split(';');
            Diak diak = new Diak(adatok[0], adatok[1], int.Parse(adatok[2]));
            diakok.Add(diak);
        }

        int kezdoX = 10, kezdoY = 15, chkYKoz = 40;
        List<CheckBox> chkBoxok = new List<CheckBox>();

        private void FelrakDiakok()
        {
            CheckBox chkBox;
            for (int i = 0; i < diakok.Count; i++)
            {
                chkBox = new CheckBox();
                chkBox.AutoSize = true;
                chkBox.Location = new Point(kezdoX, kezdoY + i * chkYKoz);
                chkBox.Text = diakok[i].ToString();
                pnlDiakok.Controls.Add(chkBox);
                chkBoxok.Add(chkBox);
            }
        }

        private void btnKivalaszt_Click(object sender, EventArgs e)
        {
            Kivalaszt();
        }

        private void Kivalaszt()
        {
            bool vanValasztott = false;
            lstKivalasztottak.Items.Clear();
            for (int i = 0; i < chkBoxok.Count; i++)
            {
                if (chkBoxok[i].Checked)
                {
                    lstKivalasztottak.Items.Add(diakok[i]);
                    vanValasztott = true;
                }
            }
            if (!vanValasztott)
            {
                MessageBox.Show("Senkit nem válaszott", "Hiba");
            }
            else
            {
                MinKeres();
            }
        }

        private void btnAdatbevitel_Click(object sender, EventArgs e)
        {
            AdatBevitel();
        }

        private void MinKeres()
        {
            lstLegidosebbek.Items.Clear();
            int min = (lstKivalasztottak.Items[0] as Diak).szulEv;
            foreach (Diak diak in lstKivalasztottak.Items)
            {
                if (diak.szulEv < min) min = diak.szulEv;
            }
            foreach (Diak diak in lstKivalasztottak.Items)
            {
                if (diak.szulEv == min) lstLegidosebbek.Items.Add(diak);
            }
        }

        private void lstKivalasztottak_SelectedIndexChanged(object sender, EventArgs e)
        {
            Diak diak = (Diak)lstKivalasztottak.SelectedItem;
            if (diak != null) lblDiak.Text = diak + ", születési éve: " + diak.szulEv;
        }
    }
}
