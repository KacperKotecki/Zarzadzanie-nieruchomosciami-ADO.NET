namespace Zarzadzanie_nieruchomosciami_ADO.NET
{
    partial class UcOplaty
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
            this.btn_usun_oplate = new System.Windows.Forms.Button();
            this.btn_edytuj_oplate = new System.Windows.Forms.Button();
            this.btn_dodaj_oplate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_prad_oplaty = new System.Windows.Forms.TextBox();
            this.cmb_status_oplaty = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_woda_oplaty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_czynsz_oplaty = new System.Windows.Forms.TextBox();
            this.dtp_data_oplaty = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_umowa_oplaty = new System.Windows.Forms.ComboBox();
            this.lb_oplaty = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView_oplaty = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_oplaty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dataGridView_oplaty);
            this.panel1.Controls.Add(this.btn_usun_oplate);
            this.panel1.Controls.Add(this.btn_edytuj_oplate);
            this.panel1.Controls.Add(this.btn_dodaj_oplate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_prad_oplaty);
            this.panel1.Controls.Add(this.cmb_status_oplaty);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_woda_oplaty);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_czynsz_oplaty);
            this.panel1.Controls.Add(this.dtp_data_oplaty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_umowa_oplaty);
            this.panel1.Controls.Add(this.lb_oplaty);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1474, 432);
            this.panel1.TabIndex = 5;
            // 
            // btn_usun_oplate
            // 
            this.btn_usun_oplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_usun_oplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_usun_oplate.Location = new System.Drawing.Point(916, 294);
            this.btn_usun_oplate.Name = "btn_usun_oplate";
            this.btn_usun_oplate.Size = new System.Drawing.Size(201, 80);
            this.btn_usun_oplate.TabIndex = 28;
            this.btn_usun_oplate.Text = "Usuń Opłate";
            this.btn_usun_oplate.UseVisualStyleBackColor = false;
            // 
            // btn_edytuj_oplate
            // 
            this.btn_edytuj_oplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_edytuj_oplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_edytuj_oplate.Location = new System.Drawing.Point(700, 294);
            this.btn_edytuj_oplate.Name = "btn_edytuj_oplate";
            this.btn_edytuj_oplate.Size = new System.Drawing.Size(201, 80);
            this.btn_edytuj_oplate.TabIndex = 27;
            this.btn_edytuj_oplate.Text = "Edytuj Opłate";
            this.btn_edytuj_oplate.UseVisualStyleBackColor = false;
            // 
            // btn_dodaj_oplate
            // 
            this.btn_dodaj_oplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_dodaj_oplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_dodaj_oplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_dodaj_oplate.Location = new System.Drawing.Point(118, 294);
            this.btn_dodaj_oplate.MinimumSize = new System.Drawing.Size(100, 80);
            this.btn_dodaj_oplate.Name = "btn_dodaj_oplate";
            this.btn_dodaj_oplate.Size = new System.Drawing.Size(354, 80);
            this.btn_dodaj_oplate.TabIndex = 26;
            this.btn_dodaj_oplate.Text = "Dodaj Opłate";
            this.btn_dodaj_oplate.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Prąd";
            // 
            // txt_prad_oplaty
            // 
            this.txt_prad_oplaty.Location = new System.Drawing.Point(139, 103);
            this.txt_prad_oplaty.Name = "txt_prad_oplaty";
            this.txt_prad_oplaty.Size = new System.Drawing.Size(145, 20);
            this.txt_prad_oplaty.TabIndex = 22;
            // 
            // cmb_status_oplaty
            // 
            this.cmb_status_oplaty.FormattingEnabled = true;
            this.cmb_status_oplaty.Location = new System.Drawing.Point(139, 129);
            this.cmb_status_oplaty.Name = "cmb_status_oplaty";
            this.cmb_status_oplaty.Size = new System.Drawing.Size(121, 21);
            this.cmb_status_oplaty.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Woda";
            // 
            // txt_woda_oplaty
            // 
            this.txt_woda_oplaty.Location = new System.Drawing.Point(139, 77);
            this.txt_woda_oplaty.Name = "txt_woda_oplaty";
            this.txt_woda_oplaty.Size = new System.Drawing.Size(145, 20);
            this.txt_woda_oplaty.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Czynsz";
            // 
            // txt_czynsz_oplaty
            // 
            this.txt_czynsz_oplaty.Location = new System.Drawing.Point(139, 41);
            this.txt_czynsz_oplaty.Name = "txt_czynsz_oplaty";
            this.txt_czynsz_oplaty.Size = new System.Drawing.Size(145, 20);
            this.txt_czynsz_oplaty.TabIndex = 6;
            // 
            // dtp_data_oplaty
            // 
            this.dtp_data_oplaty.Location = new System.Drawing.Point(139, 156);
            this.dtp_data_oplaty.Name = "dtp_data_oplaty";
            this.dtp_data_oplaty.Size = new System.Drawing.Size(233, 20);
            this.dtp_data_oplaty.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Umowy";
            // 
            // cmb_umowa_oplaty
            // 
            this.cmb_umowa_oplaty.FormattingEnabled = true;
            this.cmb_umowa_oplaty.Location = new System.Drawing.Point(139, 14);
            this.cmb_umowa_oplaty.Name = "cmb_umowa_oplaty";
            this.cmb_umowa_oplaty.Size = new System.Drawing.Size(145, 21);
            this.cmb_umowa_oplaty.TabIndex = 8;
            // 
            // lb_oplaty
            // 
            this.lb_oplaty.AutoSize = true;
            this.lb_oplaty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_oplaty.Location = new System.Drawing.Point(4, 4);
            this.lb_oplaty.Name = "lb_oplaty";
            this.lb_oplaty.Size = new System.Drawing.Size(57, 20);
            this.lb_oplaty.TabIndex = 0;
            this.lb_oplaty.Text = "Oplaty";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 432);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1474, 808);
            this.dataGridView1.TabIndex = 12;
            // 
            // dataGridView_oplaty
            // 
            this.dataGridView_oplaty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_oplaty.Location = new System.Drawing.Point(687, 50);
            this.dataGridView_oplaty.Name = "dataGridView_oplaty";
            this.dataGridView_oplaty.Size = new System.Drawing.Size(441, 213);
            this.dataGridView_oplaty.TabIndex = 29;
            // 
            // UcOplaty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "UcOplaty";
            this.Size = new System.Drawing.Size(1474, 844);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_oplaty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_data_oplaty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_umowa_oplaty;
        private System.Windows.Forms.Label lb_oplaty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_prad_oplaty;
        private System.Windows.Forms.ComboBox cmb_status_oplaty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_woda_oplaty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_czynsz_oplaty;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_usun_oplate;
        private System.Windows.Forms.Button btn_edytuj_oplate;
        private System.Windows.Forms.Button btn_dodaj_oplate;
        private System.Windows.Forms.DataGridView dataGridView_oplaty;
    }
}
