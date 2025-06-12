namespace Trafik_Cezasi_Yonetimi
{
    partial class KullaniciFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciFormu));
            this.kullanici_ad_giris = new System.Windows.Forms.TextBox();
            this.tüm_cezaları_öde = new System.Windows.Forms.Button();
            this.toplam_borç = new System.Windows.Forms.Label();
            this.sürücünün_cezaları = new System.Windows.Forms.DataGridView();
            this.OdendiMi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Surucu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CezaTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceza_öde = new System.Windows.Forms.Button();
            this.sadece_ödenmemiş_checkbox = new System.Windows.Forms.CheckBox();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.btnAnaMenuyeDon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sürücünün_cezaları)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullanici_ad_giris
            // 
            this.kullanici_ad_giris.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.kullanici_ad_giris.Location = new System.Drawing.Point(537, 60);
            this.kullanici_ad_giris.Name = "kullanici_ad_giris";
            this.kullanici_ad_giris.Size = new System.Drawing.Size(144, 22);
            this.kullanici_ad_giris.TabIndex = 0;
            this.kullanici_ad_giris.TextChanged += new System.EventHandler(this.kullanici_ad_giris_TextChanged);
            // 
            // tüm_cezaları_öde
            // 
            this.tüm_cezaları_öde.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tüm_cezaları_öde.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tüm_cezaları_öde.Location = new System.Drawing.Point(612, 162);
            this.tüm_cezaları_öde.Name = "tüm_cezaları_öde";
            this.tüm_cezaları_öde.Size = new System.Drawing.Size(147, 23);
            this.tüm_cezaları_öde.TabIndex = 16;
            this.tüm_cezaları_öde.Text = "Tüm Cezaları Öde";
            this.tüm_cezaları_öde.UseVisualStyleBackColor = false;
            this.tüm_cezaları_öde.Click += new System.EventHandler(this.tüm_cezaları_öde_Click);
            // 
            // toplam_borç
            // 
            this.toplam_borç.AutoSize = true;
            this.toplam_borç.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplam_borç.Location = new System.Drawing.Point(534, 224);
            this.toplam_borç.Name = "toplam_borç";
            this.toplam_borç.Size = new System.Drawing.Size(100, 16);
            this.toplam_borç.TabIndex = 15;
            this.toplam_borç.Text = "Toplam Borç:";
            this.toplam_borç.Click += new System.EventHandler(this.toplam_borç_Click);
            // 
            // sürücünün_cezaları
            // 
            this.sürücünün_cezaları.AllowUserToAddRows = false;
            this.sürücünün_cezaları.AllowUserToDeleteRows = false;
            this.sürücünün_cezaları.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sürücünün_cezaları.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OdendiMi,
            this.Surucu,
            this.Tutar,
            this.Tarih,
            this.CezaTipi});
            this.sürücünün_cezaları.Location = new System.Drawing.Point(250, 321);
            this.sürücünün_cezaları.Name = "sürücünün_cezaları";
            this.sürücünün_cezaları.ReadOnly = true;
            this.sürücünün_cezaları.RowHeadersWidth = 51;
            this.sürücünün_cezaları.RowTemplate.Height = 24;
            this.sürücünün_cezaları.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sürücünün_cezaları.Size = new System.Drawing.Size(726, 210);
            this.sürücünün_cezaları.TabIndex = 14;
            this.sürücünün_cezaları.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sürücünün_cezaları_CellContentClick);
            // 
            // OdendiMi
            // 
            this.OdendiMi.HeaderText = "OdendiMi";
            this.OdendiMi.MinimumWidth = 6;
            this.OdendiMi.Name = "OdendiMi";
            this.OdendiMi.ReadOnly = true;
            this.OdendiMi.Visible = false;
            this.OdendiMi.Width = 125;
            // 
            // Surucu
            // 
            this.Surucu.HeaderText = "Surucu";
            this.Surucu.MinimumWidth = 6;
            this.Surucu.Name = "Surucu";
            this.Surucu.ReadOnly = true;
            this.Surucu.Visible = false;
            this.Surucu.Width = 125;
            // 
            // Tutar
            // 
            this.Tutar.HeaderText = "Tutar";
            this.Tutar.MinimumWidth = 6;
            this.Tutar.Name = "Tutar";
            this.Tutar.ReadOnly = true;
            this.Tutar.Visible = false;
            this.Tutar.Width = 125;
            // 
            // Tarih
            // 
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.MinimumWidth = 6;
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            this.Tarih.Visible = false;
            this.Tarih.Width = 125;
            // 
            // CezaTipi
            // 
            this.CezaTipi.HeaderText = "CezaTipi";
            this.CezaTipi.MinimumWidth = 6;
            this.CezaTipi.Name = "CezaTipi";
            this.CezaTipi.ReadOnly = true;
            this.CezaTipi.Visible = false;
            this.CezaTipi.Width = 125;
            // 
            // ceza_öde
            // 
            this.ceza_öde.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ceza_öde.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ceza_öde.Location = new System.Drawing.Point(459, 162);
            this.ceza_öde.Name = "ceza_öde";
            this.ceza_öde.Size = new System.Drawing.Size(147, 23);
            this.ceza_öde.TabIndex = 13;
            this.ceza_öde.Text = "Ceza Öde\n\n";
            this.ceza_öde.UseVisualStyleBackColor = false;
            this.ceza_öde.Click += new System.EventHandler(this.ceza_öde_Click);
            // 
            // sadece_ödenmemiş_checkbox
            // 
            this.sadece_ödenmemiş_checkbox.AutoSize = true;
            this.sadece_ödenmemiş_checkbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.sadece_ödenmemiş_checkbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.sadece_ödenmemiş_checkbox.Location = new System.Drawing.Point(825, 295);
            this.sadece_ödenmemiş_checkbox.Name = "sadece_ödenmemiş_checkbox";
            this.sadece_ödenmemiş_checkbox.Size = new System.Drawing.Size(151, 20);
            this.sadece_ödenmemiş_checkbox.TabIndex = 17;
            this.sadece_ödenmemiş_checkbox.Text = "Ödenmemiş Cezalar";
            this.sadece_ödenmemiş_checkbox.UseVisualStyleBackColor = false;
            this.sadece_ödenmemiş_checkbox.CheckedChanged += new System.EventHandler(this.sadece_ödenmemiş_checkbox_CheckedChanged_1);
            // 
            // btnSorgula
            // 
            this.btnSorgula.BackColor = System.Drawing.SystemColors.Info;
            this.btnSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSorgula.Location = new System.Drawing.Point(537, 107);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(144, 25);
            this.btnSorgula.TabIndex = 18;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = false;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // btnAnaMenuyeDon
            // 
            this.btnAnaMenuyeDon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAnaMenuyeDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaMenuyeDon.Location = new System.Drawing.Point(12, 12);
            this.btnAnaMenuyeDon.Name = "btnAnaMenuyeDon";
            this.btnAnaMenuyeDon.Size = new System.Drawing.Size(140, 70);
            this.btnAnaMenuyeDon.TabIndex = 19;
            this.btnAnaMenuyeDon.Text = "Ana Menüye Dön";
            this.btnAnaMenuyeDon.UseVisualStyleBackColor = false;
            this.btnAnaMenuyeDon.Click += new System.EventHandler(this.btnAnaMenuyeDon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1054, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 125);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // KullaniciFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1215, 644);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAnaMenuyeDon);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.sadece_ödenmemiş_checkbox);
            this.Controls.Add(this.tüm_cezaları_öde);
            this.Controls.Add(this.toplam_borç);
            this.Controls.Add(this.sürücünün_cezaları);
            this.Controls.Add(this.ceza_öde);
            this.Controls.Add(this.kullanici_ad_giris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciFormu";
            this.Text = "KullaniciFormu";
            ((System.ComponentModel.ISupportInitialize)(this.sürücünün_cezaları)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kullanici_ad_giris;
        private System.Windows.Forms.Button tüm_cezaları_öde;
        private System.Windows.Forms.Label toplam_borç;
        private System.Windows.Forms.DataGridView sürücünün_cezaları;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OdendiMi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surucu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn CezaTipi;
        private System.Windows.Forms.Button ceza_öde;
        private System.Windows.Forms.CheckBox sadece_ödenmemiş_checkbox;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.Button btnAnaMenuyeDon;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}