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

        private void btn_Wczytaj_Dane_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Wlasciciele";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);

                    
                    DataTable dataTable = new DataTable();

                    
                    adapter.Fill(dataTable);

                    
                    dgv.DataSource = dataTable;
                }
                catch (Exception ex)
                { 
                    MessageBox.Show("Nie udało się pobrać danych: " + ex.Message);
                }
            }
        }

        private void btn_Dodaj_Click(object sender, EventArgs e)
        {

        }

        private void btn_Usun_Click(object sender, EventArgs e)
        {

        }
    }
}
