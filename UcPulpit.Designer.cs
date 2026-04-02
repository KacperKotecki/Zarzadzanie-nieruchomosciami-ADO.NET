namespace Zarzadzanie_nieruchomosciami_ADO.NET
{
    partial class UcPulpit
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
            this.lb_pulpiit = new System.Windows.Forms.Label();
            this.dataGridView_pulpit = new System.Windows.Forms.DataGridView();
            this.btn_zatwierdz_pulpit = new System.Windows.Forms.Button();
            this.cmb_kategoria_pulpit = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pulpit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lb_pulpiit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 36);
            this.panel1.TabIndex = 5;
            // 
            // lb_pulpiit
            // 
            this.lb_pulpiit.AutoSize = true;
            this.lb_pulpiit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_pulpiit.Location = new System.Drawing.Point(4, 4);
            this.lb_pulpiit.Name = "lb_pulpiit";
            this.lb_pulpiit.Size = new System.Drawing.Size(51, 20);
            this.lb_pulpiit.TabIndex = 0;
            this.lb_pulpiit.Text = "Pulpit";
            // 
            // dataGridView_pulpit
            // 
            this.dataGridView_pulpit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pulpit.Location = new System.Drawing.Point(53, 53);
            this.dataGridView_pulpit.Name = "dataGridView_pulpit";
            this.dataGridView_pulpit.Size = new System.Drawing.Size(1038, 224);
            this.dataGridView_pulpit.TabIndex = 6;
            // 
            // btn_zatwierdz_pulpit
            // 
            this.btn_zatwierdz_pulpit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_zatwierdz_pulpit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_zatwierdz_pulpit.Location = new System.Drawing.Point(476, 359);
            this.btn_zatwierdz_pulpit.Name = "btn_zatwierdz_pulpit";
            this.btn_zatwierdz_pulpit.Size = new System.Drawing.Size(198, 52);
            this.btn_zatwierdz_pulpit.TabIndex = 7;
            this.btn_zatwierdz_pulpit.Text = "Potwierdź";
            this.btn_zatwierdz_pulpit.UseVisualStyleBackColor = false;
            // 
            // cmb_kategoria_pulpit
            // 
            this.cmb_kategoria_pulpit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.cmb_kategoria_pulpit.FormattingEnabled = true;
            this.cmb_kategoria_pulpit.Location = new System.Drawing.Point(391, 304);
            this.cmb_kategoria_pulpit.Name = "cmb_kategoria_pulpit";
            this.cmb_kategoria_pulpit.Size = new System.Drawing.Size(358, 39);
            this.cmb_kategoria_pulpit.TabIndex = 8;
            // 
            // UcPulpit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_kategoria_pulpit);
            this.Controls.Add(this.btn_zatwierdz_pulpit);
            this.Controls.Add(this.dataGridView_pulpit);
            this.Controls.Add(this.panel1);
            this.Name = "UcPulpit";
            this.Size = new System.Drawing.Size(1132, 468);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pulpit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_pulpiit;
        private System.Windows.Forms.DataGridView dataGridView_pulpit;
        private System.Windows.Forms.Button btn_zatwierdz_pulpit;
        private System.Windows.Forms.ComboBox cmb_kategoria_pulpit;
    }
}
