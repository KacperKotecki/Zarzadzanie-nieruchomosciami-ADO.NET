namespace Zarzadzanie_nieruchomosciami_ADO.NET
{
    partial class UcUmowy
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_usun_umowe = new System.Windows.Forms.Button();
            this.btn_edytuj_umowe = new System.Windows.Forms.Button();
            this.btn_dodaj_umowe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_zakonczenie_umowa = new System.Windows.Forms.DateTimePicker();
            this.dtp_rozpoczecie_umowa = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_nieruchomosc_umowa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_najemca_umowa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_wlascicel_umowa = new System.Windows.Forms.ComboBox();
            this.lb_umowy = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView_umowa = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_umowa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dataGridView_umowa);
            this.panel1.Controls.Add(this.btn_usun_umowe);
            this.panel1.Controls.Add(this.btn_edytuj_umowe);
            this.panel1.Controls.Add(this.btn_dodaj_umowe);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtp_zakonczenie_umowa);
            this.panel1.Controls.Add(this.dtp_rozpoczecie_umowa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_nieruchomosc_umowa);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmb_najemca_umowa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_wlascicel_umowa);
            this.panel1.Controls.Add(this.lb_umowy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1459, 383);
            this.panel1.TabIndex = 4;
            // 
            // btn_usun_umowe
            // 
            this.btn_usun_umowe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_usun_umowe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_usun_umowe.Location = new System.Drawing.Point(937, 244);
            this.btn_usun_umowe.Name = "btn_usun_umowe";
            this.btn_usun_umowe.Size = new System.Drawing.Size(201, 80);
            this.btn_usun_umowe.TabIndex = 31;
            this.btn_usun_umowe.Text = "Usuń Umowe";
            this.btn_usun_umowe.UseVisualStyleBackColor = false;
            // 
            // btn_edytuj_umowe
            // 
            this.btn_edytuj_umowe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_edytuj_umowe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_edytuj_umowe.Location = new System.Drawing.Point(721, 244);
            this.btn_edytuj_umowe.Name = "btn_edytuj_umowe";
            this.btn_edytuj_umowe.Size = new System.Drawing.Size(201, 80);
            this.btn_edytuj_umowe.TabIndex = 30;
            this.btn_edytuj_umowe.Text = "Edytuj Umowe";
            this.btn_edytuj_umowe.UseVisualStyleBackColor = false;
            // 
            // btn_dodaj_umowe
            // 
            this.btn_dodaj_umowe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_dodaj_umowe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_dodaj_umowe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_dodaj_umowe.Location = new System.Drawing.Point(139, 244);
            this.btn_dodaj_umowe.MinimumSize = new System.Drawing.Size(100, 80);
            this.btn_dodaj_umowe.Name = "btn_dodaj_umowe";
            this.btn_dodaj_umowe.Size = new System.Drawing.Size(354, 80);
            this.btn_dodaj_umowe.TabIndex = 29;
            this.btn_dodaj_umowe.Text = "Dodaj Umowe";
            this.btn_dodaj_umowe.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Data Zakończenia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Data Rozpoczęcia";
            // 
            // dtp_zakonczenie_umowa
            // 
            this.dtp_zakonczenie_umowa.Location = new System.Drawing.Point(155, 165);
            this.dtp_zakonczenie_umowa.Name = "dtp_zakonczenie_umowa";
            this.dtp_zakonczenie_umowa.Size = new System.Drawing.Size(200, 20);
            this.dtp_zakonczenie_umowa.TabIndex = 16;
            // 
            // dtp_rozpoczecie_umowa
            // 
            this.dtp_rozpoczecie_umowa.Location = new System.Drawing.Point(155, 139);
            this.dtp_rozpoczecie_umowa.Name = "dtp_rozpoczecie_umowa";
            this.dtp_rozpoczecie_umowa.Size = new System.Drawing.Size(200, 20);
            this.dtp_rozpoczecie_umowa.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nieruchomości";
            // 
            // cmb_nieruchomosc_umowa
            // 
            this.cmb_nieruchomosc_umowa.FormattingEnabled = true;
            this.cmb_nieruchomosc_umowa.Location = new System.Drawing.Point(155, 112);
            this.cmb_nieruchomosc_umowa.Name = "cmb_nieruchomosc_umowa";
            this.cmb_nieruchomosc_umowa.Size = new System.Drawing.Size(121, 21);
            this.cmb_nieruchomosc_umowa.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Najemca";
            // 
            // cmb_najemca_umowa
            // 
            this.cmb_najemca_umowa.FormattingEnabled = true;
            this.cmb_najemca_umowa.Location = new System.Drawing.Point(155, 85);
            this.cmb_najemca_umowa.Name = "cmb_najemca_umowa";
            this.cmb_najemca_umowa.Size = new System.Drawing.Size(121, 21);
            this.cmb_najemca_umowa.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Właściciel";
            // 
            // cmb_wlascicel_umowa
            // 
            this.cmb_wlascicel_umowa.FormattingEnabled = true;
            this.cmb_wlascicel_umowa.Location = new System.Drawing.Point(155, 58);
            this.cmb_wlascicel_umowa.Name = "cmb_wlascicel_umowa";
            this.cmb_wlascicel_umowa.Size = new System.Drawing.Size(121, 21);
            this.cmb_wlascicel_umowa.TabIndex = 8;
            // 
            // lb_umowy
            // 
            this.lb_umowy.AutoSize = true;
            this.lb_umowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_umowy.Location = new System.Drawing.Point(4, 4);
            this.lb_umowy.Name = "lb_umowy";
            this.lb_umowy.Size = new System.Drawing.Size(64, 20);
            this.lb_umowy.TabIndex = 0;
            this.lb_umowy.Text = "Umowy";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 383);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1459, 842);
            this.dataGridView1.TabIndex = 11;
            // 
            // dataGridView_umowa
            // 
            this.dataGridView_umowa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_umowa.Location = new System.Drawing.Point(721, 58);
            this.dataGridView_umowa.Name = "dataGridView_umowa";
            this.dataGridView_umowa.Size = new System.Drawing.Size(431, 150);
            this.dataGridView_umowa.TabIndex = 32;
            // 
            // UcUmowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "UcUmowy";
            this.Size = new System.Drawing.Size(1459, 878);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_umowa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_najemca_umowa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_wlascicel_umowa;
        private System.Windows.Forms.Label lb_umowy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_zakonczenie_umowa;
        private System.Windows.Forms.DateTimePicker dtp_rozpoczecie_umowa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_nieruchomosc_umowa;
        private System.Windows.Forms.Button btn_usun_umowe;
        private System.Windows.Forms.Button btn_edytuj_umowe;
        private System.Windows.Forms.Button btn_dodaj_umowe;
        private System.Windows.Forms.DataGridView dataGridView_umowa;
    }
}
