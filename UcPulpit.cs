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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Zarzadzanie_nieruchomosciami_ADO.NET
{
    public partial class UcPulpit : UserControl
    {
        private Form1 mainForm;
        private BindingSource bsPulpit = new BindingSource();
        private SqlDataAdapter adp;


        public UcPulpit(Form1 parent)
        {
            InitializeComponent();
            this.mainForm = parent;
            InicjalizujWidok();
        }
        string nazwa_tabeli = "Wlasciciele";
        private void InicjalizujWidok()
        {

            bsPulpit.DataSource = mainForm.dsWynajem;
            bsPulpit.DataMember = nazwa_tabeli;
            dataGridView_pulpit.DataSource = bsPulpit;

            cmb_kategoria_pulpit.Items.AddRange(new string[] { "Wlasciciele", "Najemcy", "Nieruchomosci", "UmowyNajmu", "Oplaty" });

        }
        
        void pokaz_dane(string kategoria)
        {
            Form1 mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                DataSet ds = mainForm.dsWynajem;
                
                dataGridView_pulpit.DataSource = ds.Tables[kategoria];
            }
        }

        private void btn_zatwierdz_pulpit_Click(object sender, EventArgs e)
        {
            nazwa_tabeli = cmb_kategoria_pulpit.SelectedItem.ToString();
            pokaz_dane(nazwa_tabeli);
        }
    }
}
