using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zarzadzanie_nieruchomosciami_ADO.NET
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Provider=SQLOLEDB;Data Source=PC\SQLEXPRESS;Initial Catalog=ZarzadzanieNieruchomosciami;Integrated Security=SSPI;";
        public Form1()
        {
            InitializeComponent();
        }

        private void ZaladujWidok(UserControl nowyWidok)
        {
            
            panelDesktop.Controls.Clear();

            nowyWidok.Dock = DockStyle.Fill;

            panelDesktop.Controls.Add(nowyWidok);

            nowyWidok.BringToFront();
        }

        private void btnPulpit_Click(object sender, EventArgs e)
        {
            UcPulpit widokPulpitu = new UcPulpit();
            ZaladujWidok(widokPulpitu);
        }

        private void btnNajemcy_Click_1(object sender, EventArgs e)
        {
            UcNajemcy widokNajemcow = new UcNajemcy();
            ZaladujWidok(widokNajemcow);
        }
        private void btnWlasciciele_Click(object sender, EventArgs e)
        {
            UcWlasciciele widokWlascicieli = new UcWlasciciele();
            ZaladujWidok(widokWlascicieli);
        }

        private void btnNieruchomosci_Click(object sender, EventArgs e)
        {
            UcNieruchomosci widokNieruchomosci = new UcNieruchomosci();
            ZaladujWidok(widokNieruchomosci);
        }

        private void btnUmowy_Click(object sender, EventArgs e)
        {
            UcUmowy widokUmow = new UcUmowy();
            ZaladujWidok(widokUmow);
        }

        private void btnOplaty_Click(object sender, EventArgs e)
        {
            UcOplaty widokOplat = new UcOplaty();
            ZaladujWidok(widokOplat);
        }

    }
}
