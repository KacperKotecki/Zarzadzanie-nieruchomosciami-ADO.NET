using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Zarzadzanie_nieruchomosciami_ADO.NET
{
    public partial class UcUmowy : UserControl
    {
        private const string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=zarzadzanie_nieruchomosciami;Integrated Security=True";

        private Form1 mainForm;
        private BindingSource bsUmowy = new BindingSource();

        public UcUmowy(Form1 parent)
        {
            InitializeComponent();
            this.mainForm = parent;
            InicjalizujWidok();
        }

        private void InicjalizujWidok()
        {
            bsUmowy.DataSource = mainForm.dsWynajem;
            bsUmowy.DataMember = "UmowyNajmu";
            dataGridView_umowa.DataSource = bsUmowy;

            dataGridView_umowa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_umowa.MultiSelect = false;
            dataGridView_umowa.ReadOnly = true;

            DataTable dtWlasciciele = mainForm.dsWynajem.Tables["Wlasciciele"];
            DataTable dtNajemcy = mainForm.dsWynajem.Tables["Najemcy"];
            DataTable dtNieruchomosci = mainForm.dsWynajem.Tables["Nieruchomosci"];

            if (!dtWlasciciele.Columns.Contains("OpisWlasciciela"))
            {
                dtWlasciciele.Columns.Add("OpisWlasciciela", typeof(string));
                foreach (DataRow row in dtWlasciciele.Rows)
                {
                    row["OpisWlasciciela"] = $"{row["Imie"]} {row["Nazwisko"]}";
                }
            }

            if (!dtNajemcy.Columns.Contains("OpisNajemcy"))
            {
                dtNajemcy.Columns.Add("OpisNajemcy", typeof(string));
                foreach (DataRow row in dtNajemcy.Rows)
                {
                    row["OpisNajemcy"] = $"{row["Imie"]} {row["Nazwisko"]}";
                }
            }

            if (!dtNieruchomosci.Columns.Contains("OpisNieruchomosci"))
            {
                dtNieruchomosci.Columns.Add("OpisNieruchomosci", typeof(string));
                foreach (DataRow row in dtNieruchomosci.Rows)
                {
                    row["OpisNieruchomosci"] = $"{row["Miasto"]}, {row["Ulica"]}";
                }
            }

            cmb_wlascicel_umowa.DataSource = dtWlasciciele;
            cmb_wlascicel_umowa.DisplayMember = "OpisWlasciciela";
            cmb_wlascicel_umowa.ValueMember = "IdWlasciciela";

            cmb_najemca_umowa.DataSource = dtNajemcy;
            cmb_najemca_umowa.DisplayMember = "OpisNajemcy";
            cmb_najemca_umowa.ValueMember = "IdNajemcy";

            cmb_nieruchomosc_umowa.DataSource = dtNieruchomosci;
            cmb_nieruchomosc_umowa.DisplayMember = "OpisNieruchomosci";
            cmb_nieruchomosc_umowa.ValueMember = "IdNieruchomosci";

            cmb_wlascicel_umowa.DataBindings.Add("SelectedValue", bsUmowy, "IdWlasciciela", true, DataSourceUpdateMode.OnPropertyChanged);
            cmb_najemca_umowa.DataBindings.Add("SelectedValue", bsUmowy, "IdNajemcy", true, DataSourceUpdateMode.OnPropertyChanged);
            cmb_nieruchomosc_umowa.DataBindings.Add("SelectedValue", bsUmowy, "IdNieruchomosci", true, DataSourceUpdateMode.OnPropertyChanged);
            dtp_rozpoczecie_umowa.DataBindings.Add("Value", bsUmowy, "DataRozpoczecia", true, DataSourceUpdateMode.OnPropertyChanged);
            dtp_zakonczenie_umowa.DataBindings.Add("Value", bsUmowy, "DataZakonczenia", true, DataSourceUpdateMode.OnPropertyChanged);

            btn_dodaj_umowe.Click += btn_dodaj_umowe_Click;
            btn_edytuj_umowe.Click += btn_edytuj_umowe_Click;
            btn_usun_umowe.Click += btn_usun_umowe_Click;
        }

        private void ZapiszZmiany()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM UmowyNajmu", conn))
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                adapter.Update(mainForm.dsWynajem, "UmowyNajmu");
                mainForm.dsWynajem.Tables["UmowyNajmu"].Clear();
                adapter.Fill(mainForm.dsWynajem, "UmowyNajmu");
            }
        }

        private bool WalidujDaneUmowy(out string komunikat)
        {
            komunikat = "";

            if (cmb_wlascicel_umowa.SelectedValue == null)
            {
                komunikat = "Wybierz właściciela!";
                return false;
            }

            if (cmb_najemca_umowa.SelectedValue == null)
            {
                komunikat = "Wybierz najemcę!";
                return false;
            }

            if (cmb_nieruchomosc_umowa.SelectedValue == null)
            {
                komunikat = "Wybierz nieruchomość!";
                return false;
            }

            if (dtp_rozpoczecie_umowa.Value >= dtp_zakonczenie_umowa.Value)
            {
                komunikat = "Data zakończenia musi być późniejsza niż data rozpoczęcia!";
                return false;
            }

            return true;
        }

        private void btn_dodaj_umowe_Click(object sender, EventArgs e)
        {
            try
            {
                string komunikat;
                if (!WalidujDaneUmowy(out komunikat))
                {
                    MessageBox.Show(komunikat, "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                object idWlasciciela = cmb_wlascicel_umowa.SelectedValue;
                object idNajemcy = cmb_najemca_umowa.SelectedValue;
                object idNieruchomosci = cmb_nieruchomosc_umowa.SelectedValue;
                DateTime dataRozpoczecia = dtp_rozpoczecie_umowa.Value;
                DateTime dataZakonczenia = dtp_zakonczenie_umowa.Value;

                bsUmowy.AddNew();
                DataRowView nowaUmowa = (DataRowView)bsUmowy.Current;

                nowaUmowa["IdWlasciciela"] = idWlasciciela;
                nowaUmowa["IdNajemcy"] = idNajemcy;
                nowaUmowa["IdNieruchomosci"] = idNieruchomosci;
                nowaUmowa["DataRozpoczecia"] = dataRozpoczecia;
                nowaUmowa["DataZakonczenia"] = dataZakonczenia;

                bsUmowy.EndEdit();
                ZapiszZmiany();

                int iloscDni = (dataZakonczenia - dataRozpoczecia).Days;
                MessageBox.Show($"Umowa została dodana!\nCzas trwania: {iloscDni} dni", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas dodawania umowy:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_edytuj_umowe_Click(object sender, EventArgs e)
        {
            if (bsUmowy.Current != null)
            {
                try
                {
                    string komunikat;
                    if (!WalidujDaneUmowy(out komunikat))
                    {
                        MessageBox.Show(komunikat, "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    object idWlasciciela = cmb_wlascicel_umowa.SelectedValue;
                    object idNajemcy = cmb_najemca_umowa.SelectedValue;
                    object idNieruchomosci = cmb_nieruchomosc_umowa.SelectedValue;
                    DateTime dataRozpoczecia = dtp_rozpoczecie_umowa.Value;
                    DateTime dataZakonczenia = dtp_zakonczenie_umowa.Value;

                    DataRowView edytowana = (DataRowView)bsUmowy.Current;

                    edytowana["IdWlasciciela"] = idWlasciciela;
                    edytowana["IdNajemcy"] = idNajemcy;
                    edytowana["IdNieruchomosci"] = idNieruchomosci;
                    edytowana["DataRozpoczecia"] = dataRozpoczecia;
                    edytowana["DataZakonczenia"] = dataZakonczenia;

                    bsUmowy.EndEdit();
                    ZapiszZmiany();

                    int iloscDni = (dataZakonczenia - dataRozpoczecia).Days;
                    MessageBox.Show($"Umowa została zaktualizowana!\nCzas trwania: {iloscDni} dni", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd podczas edycji umowy:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wybierz umowę do edycji!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_usun_umowe_Click(object sender, EventArgs e)
        {
            if (bsUmowy.Current != null)
            {
                try
                {
                    DataRowView wybranaUmowa = (DataRowView)bsUmowy.Current;
                    DateTime dataRozpoczecia = Convert.ToDateTime(wybranaUmowa["DataRozpoczecia"]);
                    DateTime dataZakonczenia = Convert.ToDateTime(wybranaUmowa["DataZakonczenia"]);
                    int iloscDni = (dataZakonczenia - dataRozpoczecia).Days;

                    DialogResult result = MessageBox.Show(
                        $"Czy na pewno chcesz usunąć umowę?\nCzas trwania: {iloscDni} dni\nOd: {dataRozpoczecia:dd.MM.yyyy}\nDo: {dataZakonczenia:dd.MM.yyyy}",
                        "Potwierdzenie usunięcia",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        bsUmowy.RemoveCurrent();
                        ZapiszZmiany();
                        MessageBox.Show("Umowa została usunięta.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd podczas usuwania umowy:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wybierz umowę do usunięcia!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

