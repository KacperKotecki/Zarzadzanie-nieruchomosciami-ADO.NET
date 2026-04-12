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
    public partial class UcNieruchomosci : UserControl
    {
        private Form1 mainForm;
        private BindingSource bsNieruchomosci = new BindingSource();

        private SqlDataAdapter adp;
        public UcNieruchomosci(Form1 parent)
        {
            InitializeComponent();
            this.mainForm = parent;
            InicjalizujWidok();

        }

        private void InicjalizujWidok()
        {
          
            bsNieruchomosci.DataSource = mainForm.dsWynajem;
            bsNieruchomosci.DataMember = "Nieruchomosci";

            dgv_nieruchomosci.DataSource = bsNieruchomosci;
            DataTable dtWlasciciele = mainForm.dsWynajem.Tables["Wlasciciele"];

            if (!dtWlasciciele.Columns.Contains("PelneNazwisko"))
            {
                dtWlasciciele.Columns.Add("PelneNazwisko", typeof(string), "Imie + ' ' + Nazwisko");
            }

            cmb_wlasciciel.DataSource = dtWlasciciele;
            cmb_wlasciciel.DisplayMember = "PelneNazwisko"; 
            cmb_wlasciciel.ValueMember = "IdWlasciciela";

            cmb_typ.Items.Clear();
            cmb_typ.Items.AddRange(new string[] { "Mieszkanie", "Pokoj", "Lokal uslugowy", "Biuro" });
            cmb_typ.DataBindings.Add("Text", bsNieruchomosci, "TypNieruchomosci", true, DataSourceUpdateMode.OnPropertyChanged);

            // dodawanie pól tejstowych
            txt_miasto.DataBindings.Add("Text", bsNieruchomosci, "Miasto");
            txt_ulica.DataBindings.Add("Text", bsNieruchomosci, "Ulica");
            txt_l_pokoi.DataBindings.Add("Text", bsNieruchomosci, "LiczbaPokoi");
            cmb_wlasciciel.DataBindings.Add("SelectedValue", bsNieruchomosci, "IdWlasciciela", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void ZapiszZmiany()
        {
            using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            {
                adp = new SqlDataAdapter("SELECT * FROM Nieruchomosci", conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adp);

                adp.Update(mainForm.dsWynajem, "Nieruchomosci"); 
                mainForm.dsWynajem.Tables["Nieruchomosci"].Clear();
                adp.Fill(mainForm.dsWynajem, "Nieruchomosci");
            }
        }

      

        private void btn_usun_nieruchomosc_Click(object sender, EventArgs e)
        {
            if (bsNieruchomosci.Current != null)
            {
                try
                {
                    bsNieruchomosci.RemoveCurrent(); 
                    ZapiszZmiany();
                    MessageBox.Show("Rekord został usunięty."); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas usuwania: " + ex.Message); 
                }
            }
        }

        private void btn_edytuj_nieruchomosc_Click(object sender, EventArgs e)
        {
            if (bsNieruchomosci.Current != null)
            {
                try
                {
                    bsNieruchomosci.EndEdit();
                    DataRowView edytowana = (DataRowView)bsNieruchomosci.Current;
                    edytowana["Miasto"] = txt_miasto.Text;
                    edytowana["Ulica"] = txt_ulica.Text;
                    edytowana["LiczbaPokoi"] = int.Parse(txt_l_pokoi.Text);
                    edytowana["IdWlasciciela"] = cmb_wlasciciel.SelectedValue;
                    edytowana["TypNieruchomosci"] = cmb_typ.Text;
                    ZapiszZmiany();
                    MessageBox.Show("Nieruchomość została edytowana!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas edytowania: " + ex.Message);
                }
            }
        }

        private void btn_dodaj_nieruchomosc_Click(object sender, EventArgs e)
        {
            try
            {
                
                string miasto = txt_miasto.Text;
                string ulica = txt_ulica.Text;
                string lPokoiRaw = txt_l_pokoi.Text;
                string typ = cmb_typ.Text;
                object idWlasciciela = cmb_wlasciciel.SelectedValue;
                bsNieruchomosci.CancelEdit();
                if (string.IsNullOrWhiteSpace(miasto) || string.IsNullOrWhiteSpace(lPokoiRaw))
                {
                    MessageBox.Show("Uzupełnij Miasto i Liczbę pokoi!");
                    return;
                }
                
                DataTable dt = mainForm.dsWynajem.Tables["Nieruchomosci"];
                DataRow nowaNieruchomosc = dt.NewRow();

                nowaNieruchomosc["Miasto"] = miasto;
                nowaNieruchomosc["Ulica"] = ulica;
                nowaNieruchomosc["LiczbaPokoi"] = int.Parse(lPokoiRaw);
                nowaNieruchomosc["TypNieruchomosci"] = typ;
                nowaNieruchomosc["IdWlasciciela"] = idWlasciciela;

                dt.Rows.Add(nowaNieruchomosc);
                ZapiszZmiany();
                bsNieruchomosci.MoveLast();
                MessageBox.Show("Nieruchomość została dodana!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas dodawania: " + ex.Message);
            }
        }

        
    }
}
