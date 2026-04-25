using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Zarzadzanie_nieruchomosciami_ADO.NET
{
    public partial class UcOplaty : UserControl
    {
       

        private Form1 mainForm;
        private BindingSource bsOplaty = new BindingSource();

        public UcOplaty(Form1 parent)
        {
            InitializeComponent();
            this.mainForm = parent;
            InicjalizujWidok();
        }

        private void InicjalizujWidok()
        {
            DataTable dtOplaty = mainForm.dsWynajem.Tables["Oplaty"];
            if (!dtOplaty.Columns.Contains("Suma"))
            {
                DataColumn colSuma = new DataColumn("Suma", typeof(decimal));
                colSuma.Expression = "Czynsz + Woda + Prad";
                dtOplaty.Columns.Add(colSuma);
            }

            bsOplaty.DataSource = mainForm.dsWynajem;
            bsOplaty.DataMember = "Oplaty";
            dataGridView_oplaty.DataSource = bsOplaty;

            dataGridView_oplaty.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_oplaty.MultiSelect = false;
            dataGridView_oplaty.ReadOnly = true;

            DataTable dtUmowy = mainForm.dsWynajem.Tables["UmowyNajmu"];
            DataTable dtNajemcy = mainForm.dsWynajem.Tables["Najemcy"];
            DataTable dtNieruchomosci = mainForm.dsWynajem.Tables["Nieruchomosci"];

            if (!dtUmowy.Columns.Contains("OpisUmowy"))
            {
                dtUmowy.Columns.Add("OpisUmowy", typeof(string));
                foreach (DataRow row in dtUmowy.Rows)
                {
                    int idNajemcy = Convert.ToInt32(row["IdNajemcy"]);
                    int idNieruchomosci = Convert.ToInt32(row["IdNieruchomosci"]);

                    DataRow najemca = dtNajemcy.Select($"IdNajemcy = {idNajemcy}").FirstOrDefault();
                    DataRow nieruchomosc = dtNieruchomosci.Select($"IdNieruchomosci = {idNieruchomosci}").FirstOrDefault();

                    string opisNajemcy = najemca != null ? $"{najemca["Imie"]} {najemca["Nazwisko"]}" : "Brak";
                    string opisNieruchomosci = nieruchomosc != null ? $"{nieruchomosc["Miasto"]}, {nieruchomosc["Ulica"]}" : "Brak";

                    row["OpisUmowy"] = $"ID:{row["IdUmowyNajmu"]} - {opisNajemcy} - {opisNieruchomosci}";
                }
            }

            cmb_umowa_oplaty.DataSource = dtUmowy;
            cmb_umowa_oplaty.DisplayMember = "OpisUmowy";
            cmb_umowa_oplaty.ValueMember = "IdUmowyNajmu";

            string[] statusy = { "Oczekujaca", "Zaplacona", "Opozniona" };
            cmb_status_oplaty_czynsz.Items.Clear();
            cmb_status_oplaty_czynsz.Items.AddRange(statusy);
            cmb_status_oplaty_woda.Items.Clear();
            cmb_status_oplaty_woda.Items.AddRange(statusy);
            cmb_status_oplaty_prad.Items.Clear();
            cmb_status_oplaty_prad.Items.AddRange(statusy);

            txt_czynsz_oplaty.DataBindings.Add("Text", bsOplaty, "Czynsz");
            txt_woda_oplaty.DataBindings.Add("Text", bsOplaty, "Woda");
            txt_prad_oplaty.DataBindings.Add("Text", bsOplaty, "Prad");
            cmb_status_oplaty_czynsz.DataBindings.Add("Text", bsOplaty, "StatusCzynszu", true, DataSourceUpdateMode.OnPropertyChanged);
            cmb_status_oplaty_woda.DataBindings.Add("Text", bsOplaty, "StatusWody", true, DataSourceUpdateMode.OnPropertyChanged);
            cmb_status_oplaty_prad.DataBindings.Add("Text", bsOplaty, "StatusPradu", true, DataSourceUpdateMode.OnPropertyChanged);
            cmb_umowa_oplaty.DataBindings.Add("SelectedValue", bsOplaty, "IdUmowyNajmu", true, DataSourceUpdateMode.OnPropertyChanged);

            btn_dodaj_oplate.Click += btn_dodaj_oplate_Click;
            btn_edytuj_oplate.Click += btn_edytuj_oplate_Click;
            btn_usun_oplate.Click += btn_usun_oplate_Click;
        }

        private void ZapiszZmiany()
        {
            using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Oplaty", conn))
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                adapter.Update(mainForm.dsWynajem, "Oplaty");
                mainForm.dsWynajem.Tables["Oplaty"].Clear();
                adapter.Fill(mainForm.dsWynajem, "Oplaty");
            }
        }

        private bool WalidujDaneOplaty(out string komunikat)
        {
            komunikat = "";

            if (string.IsNullOrWhiteSpace(txt_czynsz_oplaty.Text))
            {
                komunikat = "Pole 'Czynsz' jest wymagane!";
                return false;
            }

            if (!decimal.TryParse(txt_czynsz_oplaty.Text, out decimal czynsz) || czynsz < 0)
            {
                komunikat = "Czynsz musi być liczbą nieujemną!";
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txt_woda_oplaty.Text))
            {
                if (!decimal.TryParse(txt_woda_oplaty.Text, out decimal woda) || woda < 0)
                {
                    komunikat = "Woda musi być liczbą nieujemną!";
                    return false;
                }
            }

            if (!string.IsNullOrWhiteSpace(txt_prad_oplaty.Text))
            {
                if (!decimal.TryParse(txt_prad_oplaty.Text, out decimal prad) || prad < 0)
                {
                    komunikat = "Prąd musi być liczbą nieujemną!";
                    return false;
                }
            }

            if (cmb_umowa_oplaty.SelectedValue == null)
            {
                komunikat = "Wybierz umowę najmu!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmb_status_oplaty_czynsz.Text))
            {
                komunikat = "Wybierz status czynszu!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmb_status_oplaty_woda.Text))
            {
                komunikat = "Wybierz status wody!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmb_status_oplaty_prad.Text))
            {
                komunikat = "Wybierz status prądu!";
                return false;
            }

            return true;
        }

        private void btn_dodaj_oplate_Click(object sender, EventArgs e)
        {
            try
            {
                string komunikat;
                if (!WalidujDaneOplaty(out komunikat))
                {
                    MessageBox.Show(komunikat, "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal czynsz = decimal.Parse(txt_czynsz_oplaty.Text);
                decimal woda = string.IsNullOrWhiteSpace(txt_woda_oplaty.Text) ? 0 : decimal.Parse(txt_woda_oplaty.Text);
                decimal prad = string.IsNullOrWhiteSpace(txt_prad_oplaty.Text) ? 0 : decimal.Parse(txt_prad_oplaty.Text);
                object idUmowy = cmb_umowa_oplaty.SelectedValue;
                string statusCzynszu = cmb_status_oplaty_czynsz.Text;
                string statusWody = cmb_status_oplaty_woda.Text;
                string statusPradu = cmb_status_oplaty_prad.Text;

                bsOplaty.AddNew();
                DataRowView nowaOplata = (DataRowView)bsOplaty.Current;

                nowaOplata["IdUmowyNajmu"] = idUmowy;
                nowaOplata["Czynsz"] = czynsz;
                nowaOplata["StatusCzynszu"] = statusCzynszu;
                nowaOplata["Woda"] = woda;
                nowaOplata["StatusWody"] = statusWody;
                nowaOplata["Prad"] = prad;
                nowaOplata["StatusPradu"] = statusPradu;

                bsOplaty.EndEdit();
                ZapiszZmiany();

                decimal suma = czynsz + woda + prad;
                MessageBox.Show($"Opłata została dodana!\nŁączna kwota: {suma}", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas dodawania opłaty:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_edytuj_oplate_Click(object sender, EventArgs e)
        {
            if (bsOplaty.Current != null)
            {
                try
                {
                    string komunikat;
                    if (!WalidujDaneOplaty(out komunikat))
                    {
                        MessageBox.Show(komunikat, "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    decimal czynsz = decimal.Parse(txt_czynsz_oplaty.Text);
                    decimal woda = string.IsNullOrWhiteSpace(txt_woda_oplaty.Text) ? 0 : decimal.Parse(txt_woda_oplaty.Text);
                    decimal prad = string.IsNullOrWhiteSpace(txt_prad_oplaty.Text) ? 0 : decimal.Parse(txt_prad_oplaty.Text);
                    object idUmowy = cmb_umowa_oplaty.SelectedValue;
                    string statusCzynszu = cmb_status_oplaty_czynsz.Text;
                    string statusWody = cmb_status_oplaty_woda.Text;
                    string statusPradu = cmb_status_oplaty_prad.Text;

                    DataRowView edytowana = (DataRowView)bsOplaty.Current;

                    edytowana["IdUmowyNajmu"] = idUmowy;
                    edytowana["Czynsz"] = czynsz;
                    edytowana["StatusCzynszu"] = statusCzynszu;
                    edytowana["Woda"] = woda;
                    edytowana["StatusWody"] = statusWody;
                    edytowana["Prad"] = prad;
                    edytowana["StatusPradu"] = statusPradu;

                    bsOplaty.EndEdit();
                    ZapiszZmiany();

                    decimal suma = czynsz + woda + prad;
                    MessageBox.Show($"Opłata została zaktualizowana!\nŁączna kwota: {suma:C}", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd podczas edycji opłaty:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wybierz opłatę do edycji!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_usun_oplate_Click(object sender, EventArgs e)
        {
            if (bsOplaty.Current != null)
            {
                try
                {
                    DataRowView wybranaOplata = (DataRowView)bsOplaty.Current;
                    decimal suma = (decimal)wybranaOplata["Czynsz"] + (decimal)wybranaOplata["Woda"] + (decimal)wybranaOplata["Prad"];
                    string statusCzynszu = wybranaOplata["StatusCzynszu"].ToString();
                    string statusWody = wybranaOplata["StatusWody"].ToString();
                    string statusPradu = wybranaOplata["StatusPradu"].ToString();

                    DialogResult result = MessageBox.Show(
                        $"Czy na pewno chcesz usunąć opłatę?\nKwota: {suma}\nCzynsz: {statusCzynszu} | Woda: {statusWody} | Prąd: {statusPradu}",
                        "Potwierdzenie usunięcia",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        bsOplaty.RemoveCurrent();
                        ZapiszZmiany();
                        MessageBox.Show("Opłata została usunięta.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd podczas usuwania opłaty:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wybierz opłatę do usunięcia!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
