namespace Zarzadzanie_nieruchomosciami_ADO.NET
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_Wczytaj_Dane = new System.Windows.Forms.Button();
            this.btn_Dodaj = new System.Windows.Forms.Button();
            this.btn_Usun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1438, 735);
            this.dgv.TabIndex = 0;
            // 
            // btn_Wczytaj_Dane
            // 
            this.btn_Wczytaj_Dane.Location = new System.Drawing.Point(12, 753);
            this.btn_Wczytaj_Dane.Name = "btn_Wczytaj_Dane";
            this.btn_Wczytaj_Dane.Size = new System.Drawing.Size(125, 44);
            this.btn_Wczytaj_Dane.TabIndex = 1;
            this.btn_Wczytaj_Dane.Text = "Wczytaj Dane";
            this.btn_Wczytaj_Dane.UseVisualStyleBackColor = true;
            this.btn_Wczytaj_Dane.Click += new System.EventHandler(this.btn_Wczytaj_Dane_Click);
            // 
            // btn_Dodaj
            // 
            this.btn_Dodaj.Location = new System.Drawing.Point(143, 753);
            this.btn_Dodaj.Name = "btn_Dodaj";
            this.btn_Dodaj.Size = new System.Drawing.Size(125, 44);
            this.btn_Dodaj.TabIndex = 2;
            this.btn_Dodaj.Text = "Dodaj";
            this.btn_Dodaj.UseVisualStyleBackColor = true;
            this.btn_Dodaj.Click += new System.EventHandler(this.btn_Dodaj_Click);
            // 
            // btn_Usun
            // 
            this.btn_Usun.Location = new System.Drawing.Point(274, 753);
            this.btn_Usun.Name = "btn_Usun";
            this.btn_Usun.Size = new System.Drawing.Size(125, 44);
            this.btn_Usun.TabIndex = 3;
            this.btn_Usun.Text = "Usun";
            this.btn_Usun.UseVisualStyleBackColor = true;
            this.btn_Usun.Click += new System.EventHandler(this.btn_Usun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 823);
            this.Controls.Add(this.btn_Usun);
            this.Controls.Add(this.btn_Dodaj);
            this.Controls.Add(this.btn_Wczytaj_Dane);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_Wczytaj_Dane;
        private System.Windows.Forms.Button btn_Dodaj;
        private System.Windows.Forms.Button btn_Usun;
    }
}

