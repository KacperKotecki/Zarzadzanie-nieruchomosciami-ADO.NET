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
    public partial class UcWlasciciele : UserControl
    {


        private Form1 mainForm;
        private BindingSource bsWlasciele = new BindingSource();
        private SqlDataAdapter adp;

        public UcWlasciciele(Form1 parent)
        {
            InitializeComponent();
            this.mainForm = parent;
            InicjalizujWidok();
        }

        private void InicjalizujWidok()
        {

            bsWlasciele.DataSource = mainForm.dsWynajem;
            bsWlasciele.DataMember = "Wlasciciele";
            dataGridView_wlasciciel.DataSource = bsWlasciele;

            txt_imie_wlasciciela.DataBindings.Add("Text", bsWlasciele, "Imie");
            txt_nazwisko_wlasciciela.DataBindings.Add("Text", bsWlasciele, "Nazwisko");
            txt_PESEL_wlasciciela.DataBindings.Add("Text", bsWlasciele, "PESEL");
            txt_tel_wlasciciela.DataBindings.Add("Text", bsWlasciele, "Telefon");
            txt_email_wlasciciela.DataBindings.Add("Text", bsWlasciele, "Email");
            txt_bank_wlascicela.DataBindings.Add("Text", bsWlasciele, "NumerKontaBankowego");

        }

        private void ZapiszZmiany()
        {
            using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            {
                adp = new SqlDataAdapter("SELECT * FROM Wlasciciele", conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adp);

                adp.Update(mainForm.dsWynajem, "Wlasciciele");
                mainForm.dsWynajem.Tables["Wlasciciele"].Clear();
                adp.Fill(mainForm.dsWynajem, "Wlasciciele");
            }
        }
        private bool CzyPeselSiePowtarza(string pesel, int aktualneId = -1)
        {
            DataTable dt = mainForm.dsWynajem.Tables["Wlasciciele"];

            if (dt == null)
            {
                MessageBox.Show("Błąd: Tabela 'Wlasciciele' nie została odnaleziona w pamięci!");
                return false;
            }

            string filtr = $"PESEL = '{pesel}'";
            if (aktualneId != -1)
            {
                filtr += $" AND IdWlasciciela <> {aktualneId}"; 
            }

            DataRow[] znalezione = dt.Select(filtr);
            return znalezione.Length > 0;
        }




        private void btn_dodaj_wlascicela_Click(object sender, EventArgs e)
        {
            try
            {

                string imie = txt_imie_wlasciciela.Text;
                string nazwisko = txt_nazwisko_wlasciciela.Text;
                string PESEL = txt_PESEL_wlasciciela.Text;
                string tel = txt_tel_wlasciciela.Text;
                string email = txt_email_wlasciciela.Text;
                string numerKonta = txt_bank_wlascicela.Text;
                bsWlasciele.CancelEdit();

                if (string.IsNullOrWhiteSpace(PESEL) || string.IsNullOrWhiteSpace(tel))
                {
                    MessageBox.Show("Uzupełnij dane!");
                    return;
                }
                if (CzyPeselSiePowtarza(PESEL))
                {
                    MessageBox.Show("Błąd! Najemca o podanym numerze PESEL już istnieje w bazie.",
                                    "Duplikat danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable dt = mainForm.dsWynajem.Tables["Najemcy"];
                DataRow wlascicel = dt.NewRow();

                wlascicel["Imie"] = imie;
                wlascicel["Nazwisko"] = nazwisko;
                wlascicel["PESEL"] = PESEL;
                wlascicel["Telefon"] = tel;
                wlascicel["Email"] = email;
                wlascicel["NumerKontaBankowego"] = numerKonta;

                dt.Rows.Add(wlascicel);
                ZapiszZmiany();
                bsWlasciele.MoveLast();
                MessageBox.Show("Najemca został dodany!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas dodawania: " + ex.Message);
            }
        }

        private void btn_edytuj_wlasciela_Click(object sender, EventArgs e)
        {
            if (bsWlasciele.Current != null)
            {
                try
                {
                    DataRowView edytowana = (DataRowView)bsWlasciele.Current;
                    int idObecnego = (int)edytowana["IdWlasciciela"];
                    string nowyPesel = txt_PESEL_wlasciciela.Text;
                    if (CzyPeselSiePowtarza(nowyPesel, idObecnego))
                    {
                        MessageBox.Show("Nie można zapisać zmian! Ten numer PESEL jest już przypisany do innego Wlascicela.",
                                        "Błąd duplikacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    bsWlasciele.EndEdit();
                    edytowana["Imie"] = txt_imie_wlasciciela.Text;
                    edytowana["Nazwisko"] = txt_nazwisko_wlasciciela.Text;
                    edytowana["PESEL"] = nowyPesel;
                    edytowana["Telefon"] = txt_tel_wlasciciela.Text;
                    edytowana["Email"] = txt_email_wlasciciela.Text;
                    edytowana["NumerKontaBankowego"] = txt_bank_wlascicela.Text;

                    ZapiszZmiany();
                    MessageBox.Show("Dane wlasciela, zostały pomyślnie zaktualizowane!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas edytowania: " + ex.Message);
                }
            }
        }

        private void btn_usun_wlascicela_Click(object sender, EventArgs e)
        {
            if (bsWlasciele.Current != null)
            {
                try
                {
                    bsWlasciele.RemoveCurrent();
                    ZapiszZmiany();
                    MessageBox.Show("Rekord został usunięty.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas usuwania: " + ex.Message);
                }
            }
        }
    }
}

