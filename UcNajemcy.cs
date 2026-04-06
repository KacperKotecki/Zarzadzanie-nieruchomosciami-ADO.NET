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
    public partial class UcNajemcy : UserControl
    {

        private Form1 mainForm;
        private BindingSource bsNajemcy = new BindingSource();
        private SqlDataAdapter adp;


        public UcNajemcy(Form1 parent)
        {
            InitializeComponent();
            this.mainForm = parent;
            InicjalizujWidok();
        }



        private void InicjalizujWidok()
        {

            bsNajemcy.DataSource = mainForm.dsWynajem;
            bsNajemcy.DataMember = "Najemcy";
            dataGridView_najemcy.DataSource = bsNajemcy;

            TXT_IMIE_NAJEMCY.DataBindings.Add("Text", bsNajemcy, "Imie");
            TXT_NAZWISKO_NAJEMCY.DataBindings.Add("Text", bsNajemcy, "Nazwisko");
            TXT_PESEL_NAJEMCY.DataBindings.Add("Text", bsNajemcy, "PESEL");
            TXT_TEL_NAJEMCY.DataBindings.Add("Text", bsNajemcy, "Telefon");
            TXT_EMAIL_NAJEMCY.DataBindings.Add("Text", bsNajemcy, "Email");

        }

        private void ZapiszZmiany()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=zarzadzanie_nieruchomosciami;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                adp = new SqlDataAdapter("SELECT * FROM Najemcy", conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adp);

                adp.Update(mainForm.dsWynajem, "Najemcy");
                mainForm.dsWynajem.Tables["Najemcy"].Clear();
                adp.Fill(mainForm.dsWynajem, "Najemcy");
            }
        }
        private bool CzyPeselSiePowtarza(string pesel, int aktualneId = -1)
        {
            DataTable dt = mainForm.dsWynajem.Tables["Najemcy"];
            string filtr = $"PESEL = '{pesel}'";
            if (aktualneId != -1)
            {
                filtr += $" AND IdNajemcy <> {aktualneId}";
            }
            DataRow[] znalezione = dt.Select(filtr);
            return znalezione.Length > 0;
        }











        private void btn_dodaj_niajemce_Click(object sender, EventArgs e)
        {
            try
            {

                string imie = TXT_IMIE_NAJEMCY.Text;
                string nazwisko = TXT_NAZWISKO_NAJEMCY.Text;
                string PESEL = TXT_PESEL_NAJEMCY.Text;
                string tel = TXT_TEL_NAJEMCY.Text;
                string email = TXT_EMAIL_NAJEMCY.Text;
                bsNajemcy.CancelEdit();

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
                DataRow najemca = dt.NewRow();

                najemca["Imie"] = imie;
                najemca["Nazwisko"] = nazwisko;
                najemca["PESEL"] = PESEL;
                najemca["Telefon"] = tel;
                najemca["Email"] = email;

                dt.Rows.Add(najemca);
                ZapiszZmiany();
                bsNajemcy.MoveLast();
                MessageBox.Show("Najemca został dodany!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas dodawania: " + ex.Message);
            }
        }

        private void btn_edytuj_najemce_Click(object sender, EventArgs e)
        {
            if (bsNajemcy.Current != null)
            {
                try
                {
                    DataRowView edytowana = (DataRowView)bsNajemcy.Current;
                    int idObecnego = (int)edytowana["IdNajemcy"];
                    string nowyPesel = TXT_PESEL_NAJEMCY.Text;
                    if (CzyPeselSiePowtarza(nowyPesel, idObecnego))
                    {
                        MessageBox.Show("Nie można zapisać zmian! Ten numer PESEL jest już przypisany do innego najemcy.",
                                        "Błąd duplikacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 
                    }
                    bsNajemcy.EndEdit();
                    edytowana["Imie"] = TXT_IMIE_NAJEMCY.Text;
                    edytowana["Nazwisko"] = TXT_NAZWISKO_NAJEMCY.Text;
                    edytowana["PESEL"] = nowyPesel;
                    edytowana["Telefon"] = TXT_TEL_NAJEMCY.Text;
                    edytowana["Email"] = TXT_EMAIL_NAJEMCY.Text;

                    ZapiszZmiany();
                    MessageBox.Show("Dane najemcy zostały pomyślnie zaktualizowane!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas edytowania: " + ex.Message);
                }
            }
        }

        private void btn_usun_najemce_Click(object sender, EventArgs e)
        {
            if (bsNajemcy.Current != null)
            {
                try
                {
                    bsNajemcy.RemoveCurrent();
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
