using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zarzadzanie_nieruchomosciami_ADO.NET
{
    public partial class Form1 : Form
    {
        
        public static string connectionString = @"Server=DELL\SQLEXPRESS;Database=Zarzadanie_Nieruchomosciami;Integrated Security=True;TrustServerCertificate=True;";

        public DataSet dsWynajem = new DataSet("WynajemDS");

        public Form1()
        {
            InitializeComponent();
            DodajBazeDanych();
            btnPulpit_Click(null, null); // udawane klikniecie w przycisk pulpitu, zeby od razu pokazal sie pulpit
        }

        private void DodajBazeDanych()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string[] tabele = { "Wlasciciele", "Najemcy", "Nieruchomosci", "UmowyNajmu", "Oplaty" };

                    foreach (string nazwa in tabele)
                    {
                        SqlDataAdapter adp = new SqlDataAdapter($"SELECT * FROM {nazwa}", connection);
                        adp.Fill(dsWynajem, nazwa); 
                    }
                }
                catch (Exception ex)
                {
                   MessageBox.Show("Błąd inicjalizacji bazy: " + ex.Message);
                }
                finally
                {
                    connection.Close(); 
                }
            }
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
            UcPulpit widokPulpitu = new UcPulpit(this);
            ZaladujWidok(widokPulpitu);
        }

        private void btnNajemcy_Click_1(object sender, EventArgs e)
        {
            UcNajemcy widokNajemcow = new UcNajemcy(this);
            ZaladujWidok(widokNajemcow);
        }
        private void btnWlasciciele_Click(object sender, EventArgs e)
        {
            UcWlasciciele widokWlascicieli = new UcWlasciciele(this);
            ZaladujWidok(widokWlascicieli);
        }

        private void btnNieruchomosci_Click(object sender, EventArgs e)
        {
            UcNieruchomosci widok = new UcNieruchomosci(this);
            ZaladujWidok(widok);
        }

        private void btnUmowy_Click(object sender, EventArgs e)
        {
            UcUmowy widokUmow = new UcUmowy(this);
            ZaladujWidok(widokUmow);
        }

        private void btnOplaty_Click(object sender, EventArgs e)
        {
            UcOplaty widokOplat = new UcOplaty(this);
            ZaladujWidok(widokOplat);
        }

    }
}
