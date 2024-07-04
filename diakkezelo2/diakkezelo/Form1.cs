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
        List<int> evek = new List<int>();

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
                    FelrakEvek();
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
            Diak diak;
            diak = new Diak(adatok[0], adatok[1], int.Parse(adatok[2]));
            lstDiakok.Items.Add(diak);
            if (!evek.Contains(diak.szulEv)) evek.Add(diak.szulEv);
        }

        int kezdoX = 10, kezdoY = 7, btnXKoz = 80;
        List<Button> btnEvek = new List<Button>();

        private void FelrakEvek()
        {
            Button btn;
            evek.Sort();
            for (int i = 0; i < evek.Count; i++)
            {
                btn = new Button();
                btn.Location = new Point(kezdoX + i * btnXKoz, kezdoY);
                btn.Text = evek[i].ToString();
                btn.Click += new System.EventHandler(Kivalaszt);
                pnlEvek.Controls.Add(btn);
                btnEvek.Add(btn);
            }
        }

        private void lstEredmeny_SelectedIndexChanged(object sender, EventArgs e)
        {
            Diak diak = (Diak)lstEredmeny.SelectedItem;
            if (diak != null) lblDiak.Text = diak + ", születési éve: " + diak.szulEv;
        }

        private void Kivalaszt(object sender, EventArgs e)
        {
            int ev = int.Parse((sender as Button).Text);
            lstEredmeny.Items.Clear();
            foreach (Diak diak in lstDiakok.Items)
            {
                if (diak.szulEv == ev) lstEredmeny.Items.Add(diak);
            }
        }

        private void btnAdatbevitel_Click(object sender, EventArgs e)
        {
            AdatBevitel();
        }
    }
}
