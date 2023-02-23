namespace RestaurantApp.Ui
{
    partial class SiparisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTasi = new System.Windows.Forms.Button();
            this.cboUrun = new System.Windows.Forms.ComboBox();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.btnSiparisIptal = new System.Windows.Forms.Button();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.btnAnasayfayaDon = new System.Windows.Forms.Button();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDetaylar = new System.Windows.Forms.DataGridView();
            this.lblOdemeTutari = new System.Windows.Forms.Label();
            this.cboMasaNo = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaylar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(360, 29);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(112, 25);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTasi
            // 
            this.btnTasi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTasi.Location = new System.Drawing.Point(845, 29);
            this.btnTasi.Name = "btnTasi";
            this.btnTasi.Size = new System.Drawing.Size(112, 25);
            this.btnTasi.TabIndex = 1;
            this.btnTasi.Text = "TAŞI";
            this.btnTasi.UseVisualStyleBackColor = true;
            // 
            // cboUrun
            // 
            this.cboUrun.FormattingEnabled = true;
            this.cboUrun.Location = new System.Drawing.Point(13, 29);
            this.cboUrun.Name = "cboUrun";
            this.cboUrun.Size = new System.Drawing.Size(196, 21);
            this.cboUrun.TabIndex = 3;
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(233, 30);
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(105, 20);
            this.nudAdet.TabIndex = 4;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSiparisIptal
            // 
            this.btnSiparisIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiparisIptal.BackColor = System.Drawing.Color.Maroon;
            this.btnSiparisIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisIptal.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSiparisIptal.Location = new System.Drawing.Point(719, 296);
            this.btnSiparisIptal.Name = "btnSiparisIptal";
            this.btnSiparisIptal.Size = new System.Drawing.Size(112, 50);
            this.btnSiparisIptal.TabIndex = 5;
            this.btnSiparisIptal.Text = "SİPARİŞ İPTAL";
            this.btnSiparisIptal.UseVisualStyleBackColor = false;
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdemeAl.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOdemeAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeAl.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOdemeAl.Location = new System.Drawing.Point(845, 296);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(112, 50);
            this.btnOdemeAl.TabIndex = 6;
            this.btnOdemeAl.Text = "ÖDEME AL";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            // 
            // btnAnasayfayaDon
            // 
            this.btnAnasayfayaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnasayfayaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAnasayfayaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfayaDon.ForeColor = System.Drawing.Color.Snow;
            this.btnAnasayfayaDon.Location = new System.Drawing.Point(719, 365);
            this.btnAnasayfayaDon.Name = "btnAnasayfayaDon";
            this.btnAnasayfayaDon.Size = new System.Drawing.Size(238, 49);
            this.btnAnasayfayaDon.TabIndex = 7;
            this.btnAnasayfayaDon.Text = "ANASAYFAYA DÖN";
            this.btnAnasayfayaDon.UseVisualStyleBackColor = false;
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMasaNo.BackColor = System.Drawing.Color.SandyBrown;
            this.lblMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMasaNo.Location = new System.Drawing.Point(719, 71);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(238, 176);
            this.lblMasaNo.TabIndex = 8;
            this.lblMasaNo.Text = "00";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ürün";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(229, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Adet";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(722, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Masa No";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(722, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ödeme Tutarı :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDetaylar
            // 
            this.dgvDetaylar.AllowUserToAddRows = false;
            this.dgvDetaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetaylar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvDetaylar.Location = new System.Drawing.Point(13, 57);
            this.dgvDetaylar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetaylar.Name = "dgvDetaylar";
            this.dgvDetaylar.ReadOnly = true;
            this.dgvDetaylar.RowHeadersVisible = false;
            this.dgvDetaylar.RowHeadersWidth = 62;
            this.dgvDetaylar.RowTemplate.Height = 28;
            this.dgvDetaylar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetaylar.Size = new System.Drawing.Size(689, 363);
            this.dgvDetaylar.TabIndex = 14;
            // 
            // lblOdemeTutari
            // 
            this.lblOdemeTutari.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOdemeTutari.BackColor = System.Drawing.SystemColors.Control;
            this.lblOdemeTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeTutari.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOdemeTutari.Location = new System.Drawing.Point(863, 257);
            this.lblOdemeTutari.Name = "lblOdemeTutari";
            this.lblOdemeTutari.Size = new System.Drawing.Size(68, 32);
            this.lblOdemeTutari.TabIndex = 15;
            this.lblOdemeTutari.Text = "0,00₺";
            this.lblOdemeTutari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboMasaNo
            // 
            this.cboMasaNo.FormattingEnabled = true;
            this.cboMasaNo.Location = new System.Drawing.Point(710, 29);
            this.cboMasaNo.Name = "cboMasaNo";
            this.cboMasaNo.Size = new System.Drawing.Size(110, 21);
            this.cboMasaNo.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UrunAd";
            this.Column1.HeaderText = "Ürün";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BirimFiyat";
            dataGridViewCellStyle1.Format = "C2";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Birim Fiyat";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Adet";
            this.Column3.HeaderText = "Adet";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TutarTL";
            this.Column4.HeaderText = "Tutar";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 180;
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 437);
            this.Controls.Add(this.cboMasaNo);
            this.Controls.Add(this.lblOdemeTutari);
            this.Controls.Add(this.dgvDetaylar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.btnAnasayfayaDon);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.btnSiparisIptal);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.cboUrun);
            this.Controls.Add(this.btnTasi);
            this.Controls.Add(this.btnEkle);
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaylar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTasi;
        private System.Windows.Forms.ComboBox cboUrun;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Button btnSiparisIptal;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.Button btnAnasayfayaDon;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDetaylar;
        private System.Windows.Forms.Label lblOdemeTutari;
        private System.Windows.Forms.ComboBox cboMasaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}