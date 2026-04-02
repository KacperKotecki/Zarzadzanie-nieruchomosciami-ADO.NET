namespace Zarzadzanie_nieruchomosciami_ADO.NET
{
    partial class UcNieruchomosci
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
            this.btn_usun_nieruchomosc = new System.Windows.Forms.Button();
            this.btn_edytuj_nieruchomosc = new System.Windows.Forms.Button();
            this.dgv_nieruchomosci = new System.Windows.Forms.DataGridView();
            this.btn_dodaj_nieruchomosc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_typ = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_wlasciciel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_l_pokoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ulica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_miasto = new System.Windows.Forms.TextBox();
            this.lb_nieruchomosci = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nieruchomosci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btn_usun_nieruchomosc);
            this.panel1.Controls.Add(this.btn_edytuj_nieruchomosc);
            this.panel1.Controls.Add(this.dgv_nieruchomosci);
            this.panel1.Controls.Add(this.btn_dodaj_nieruchomosc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmb_typ);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_wlasciciel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_l_pokoi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_ulica);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_miasto);
            this.panel1.Controls.Add(this.lb_nieruchomosci);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1529, 496);
            this.panel1.TabIndex = 3;
            // 
            // btn_usun_nieruchomosc
            // 
            this.btn_usun_nieruchomosc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_usun_nieruchomosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_usun_nieruchomosc.Location = new System.Drawing.Point(972, 360);
            this.btn_usun_nieruchomosc.Name = "btn_usun_nieruchomosc";
            this.btn_usun_nieruchomosc.Size = new System.Drawing.Size(201, 80);
            this.btn_usun_nieruchomosc.TabIndex = 16;
            this.btn_usun_nieruchomosc.Text = "Usuń Nieruchomość";
            this.btn_usun_nieruchomosc.UseVisualStyleBackColor = false;
            this.btn_usun_nieruchomosc.Click += new System.EventHandler(this.btn_usun_nieruchomosc_Click);
            // 
            // btn_edytuj_nieruchomosc
            // 
            this.btn_edytuj_nieruchomosc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_edytuj_nieruchomosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_edytuj_nieruchomosc.Location = new System.Drawing.Point(756, 360);
            this.btn_edytuj_nieruchomosc.Name = "btn_edytuj_nieruchomosc";
            this.btn_edytuj_nieruchomosc.Size = new System.Drawing.Size(201, 80);
            this.btn_edytuj_nieruchomosc.TabIndex = 15;
            this.btn_edytuj_nieruchomosc.Text = "Edytuj Nieruchomość";
            this.btn_edytuj_nieruchomosc.UseVisualStyleBackColor = false;
            this.btn_edytuj_nieruchomosc.Click += new System.EventHandler(this.btn_edytuj_nieruchomosc_Click);
            // 
            // dgv_nieruchomosci
            // 
            this.dgv_nieruchomosci.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgv_nieruchomosci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nieruchomosci.Location = new System.Drawing.Point(604, 72);
            this.dgv_nieruchomosci.Name = "dgv_nieruchomosci";
            this.dgv_nieruchomosci.ReadOnly = true;
            this.dgv_nieruchomosci.Size = new System.Drawing.Size(691, 258);
            this.dgv_nieruchomosci.TabIndex = 14;
            // 
            // btn_dodaj_nieruchomosc
            // 
            this.btn_dodaj_nieruchomosc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_dodaj_nieruchomosc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_dodaj_nieruchomosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_dodaj_nieruchomosc.Location = new System.Drawing.Point(174, 360);
            this.btn_dodaj_nieruchomosc.MinimumSize = new System.Drawing.Size(100, 80);
            this.btn_dodaj_nieruchomosc.Name = "btn_dodaj_nieruchomosc";
            this.btn_dodaj_nieruchomosc.Size = new System.Drawing.Size(354, 80);
            this.btn_dodaj_nieruchomosc.TabIndex = 13;
            this.btn_dodaj_nieruchomosc.Text = "Dodaj Nieruchomość";
            this.btn_dodaj_nieruchomosc.UseVisualStyleBackColor = false;
            this.btn_dodaj_nieruchomosc.Click += new System.EventHandler(this.btn_dodaj_nieruchomosc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label5.Location = new System.Drawing.Point(221, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 44);
            this.label5.TabIndex = 12;
            this.label5.Text = "Typ";
            // 
            // cmb_typ
            // 
            this.cmb_typ.FormattingEnabled = true;
            this.cmb_typ.Location = new System.Drawing.Point(337, 283);
            this.cmb_typ.Name = "cmb_typ";
            this.cmb_typ.Size = new System.Drawing.Size(191, 21);
            this.cmb_typ.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label4.Location = new System.Drawing.Point(113, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 44);
            this.label4.TabIndex = 10;
            this.label4.Text = "Właściciel";
            // 
            // cmb_wlasciciel
            // 
            this.cmb_wlasciciel.FormattingEnabled = true;
            this.cmb_wlasciciel.Location = new System.Drawing.Point(337, 238);
            this.cmb_wlasciciel.Name = "cmb_wlasciciel";
            this.cmb_wlasciciel.Size = new System.Drawing.Size(191, 21);
            this.cmb_wlasciciel.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label3.Location = new System.Drawing.Point(69, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 44);
            this.label3.TabIndex = 7;
            this.label3.Text = "Liczba Pokoi";
            // 
            // txt_l_pokoi
            // 
            this.txt_l_pokoi.Location = new System.Drawing.Point(337, 183);
            this.txt_l_pokoi.MinimumSize = new System.Drawing.Size(4, 30);
            this.txt_l_pokoi.Name = "txt_l_pokoi";
            this.txt_l_pokoi.Size = new System.Drawing.Size(191, 20);
            this.txt_l_pokoi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label2.Location = new System.Drawing.Point(199, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ulica";
            // 
            // txt_ulica
            // 
            this.txt_ulica.Location = new System.Drawing.Point(337, 136);
            this.txt_ulica.MinimumSize = new System.Drawing.Size(4, 30);
            this.txt_ulica.Name = "txt_ulica";
            this.txt_ulica.Size = new System.Drawing.Size(191, 20);
            this.txt_ulica.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(175, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Miasto";
            // 
            // txt_miasto
            // 
            this.txt_miasto.Location = new System.Drawing.Point(337, 83);
            this.txt_miasto.MinimumSize = new System.Drawing.Size(4, 30);
            this.txt_miasto.Name = "txt_miasto";
            this.txt_miasto.Size = new System.Drawing.Size(191, 20);
            this.txt_miasto.TabIndex = 1;
            // 
            // lb_nieruchomosci
            // 
            this.lb_nieruchomosci.AutoSize = true;
            this.lb_nieruchomosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_nieruchomosci.Location = new System.Drawing.Point(4, 4);
            this.lb_nieruchomosci.Name = "lb_nieruchomosci";
            this.lb_nieruchomosci.Size = new System.Drawing.Size(121, 20);
            this.lb_nieruchomosci.TabIndex = 0;
            this.lb_nieruchomosci.Text = "Nieruchomości";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 496);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1529, 812);
            this.dataGridView1.TabIndex = 10;
            // 
            // UcNieruchomosci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "UcNieruchomosci";
            this.Size = new System.Drawing.Size(1529, 848);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nieruchomosci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_l_pokoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ulica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_miasto;
        private System.Windows.Forms.Label lb_nieruchomosci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_wlasciciel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_typ;
        private System.Windows.Forms.Button btn_dodaj_nieruchomosc;
        private System.Windows.Forms.DataGridView dgv_nieruchomosci;
        private System.Windows.Forms.Button btn_usun_nieruchomosc;
        private System.Windows.Forms.Button btn_edytuj_nieruchomosc;
    }
}
