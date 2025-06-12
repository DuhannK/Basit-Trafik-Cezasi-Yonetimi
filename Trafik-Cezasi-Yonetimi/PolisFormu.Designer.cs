namespace Trafik_Cezasi_Yonetimi
{
    partial class PolisFormu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolisFormu));
            this.sürücü_ekle = new System.Windows.Forms.Button();
            this.ceza_ekle = new System.Windows.Forms.Button();
            this.sürücü_adı_girişi = new System.Windows.Forms.TextBox();
            this.ceza_seçenek_seçimi = new System.Windows.Forms.ComboBox();
            this.ceza_tutarı_girişi = new System.Windows.Forms.TextBox();
            this.sürücüler_liste = new System.Windows.Forms.ListBox();
            this.sürücünün_cezaları = new System.Windows.Forms.DataGridView();
            this.OdendiMi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Surucu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CezaTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplam_borç = new System.Windows.Forms.Label();
            this.btnCezayiSil = new System.Windows.Forms.Button();
            this.btnAnaMenuyeDon = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sürücünün_cezaları)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sürücü_ekle
            // 
            this.sürücü_ekle.BackColor = System.Drawing.SystemColors.Info;
            this.sürücü_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sürücü_ekle.Location = new System.Drawing.Point(331, 26);
            this.sürücü_ekle.Name = "sürücü_ekle";
            this.sürücü_ekle.Size = new System.Drawing.Size(147, 23);
            this.sürücü_ekle.TabIndex = 0;
            this.sürücü_ekle.Text = "Sürücü Ekle\n\n";
            this.sürücü_ekle.UseVisualStyleBackColor = false;
            this.sürücü_ekle.Click += new System.EventHandler(this.sürücü_ekle_Click);
            // 
            // ceza_ekle
            // 
            this.ceza_ekle.BackColor = System.Drawing.SystemColors.Info;
            this.ceza_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ceza_ekle.Location = new System.Drawing.Point(331, 152);
            this.ceza_ekle.Name = "ceza_ekle";
            this.ceza_ekle.Size = new System.Drawing.Size(147, 23);
            this.ceza_ekle.TabIndex = 1;
            this.ceza_ekle.Text = "Ceza Ekle\n\n";
            this.ceza_ekle.UseVisualStyleBackColor = false;
            this.ceza_ekle.Click += new System.EventHandler(this.ceza_ekle_Click);
            // 
            // sürücü_adı_girişi
            // 
            this.sürücü_adı_girişi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sürücü_adı_girişi.ForeColor = System.Drawing.SystemColors.MenuText;
            this.sürücü_adı_girişi.Location = new System.Drawing.Point(296, 55);
            this.sürücü_adı_girişi.Name = "sürücü_adı_girişi";
            this.sürücü_adı_girişi.Size = new System.Drawing.Size(217, 22);
            this.sürücü_adı_girişi.TabIndex = 4;
            this.sürücü_adı_girişi.Tag = "";
            this.sürücü_adı_girişi.Text = "Ad Soyad";
            this.sürücü_adı_girişi.TextChanged += new System.EventHandler(this.sürücü_adı_girişi_TextChanged);
            this.sürücü_adı_girişi.Enter += new System.EventHandler(this.sürücü_adı_girişi_Enter);
            this.sürücü_adı_girişi.Leave += new System.EventHandler(this.sürücü_adı_girişi_Leave);
            // 
            // ceza_seçenek_seçimi
            // 
            this.ceza_seçenek_seçimi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ceza_seçenek_seçimi.FormattingEnabled = true;
            this.ceza_seçenek_seçimi.Location = new System.Drawing.Point(296, 209);
            this.ceza_seçenek_seçimi.Name = "ceza_seçenek_seçimi";
            this.ceza_seçenek_seçimi.Size = new System.Drawing.Size(217, 24);
            this.ceza_seçenek_seçimi.TabIndex = 5;
            this.ceza_seçenek_seçimi.Text = "Ceza Türünü Seçin";
            this.ceza_seçenek_seçimi.SelectedIndexChanged += new System.EventHandler(this.ceza_seçenek_seçimi_SelectedIndexChanged);
            // 
            // ceza_tutarı_girişi
            // 
            this.ceza_tutarı_girişi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ceza_tutarı_girişi.Location = new System.Drawing.Point(296, 181);
            this.ceza_tutarı_girişi.Name = "ceza_tutarı_girişi";
            this.ceza_tutarı_girişi.Size = new System.Drawing.Size(217, 22);
            this.ceza_tutarı_girişi.TabIndex = 6;
            this.ceza_tutarı_girişi.Text = "Ceza Tutarı Giriniz";
            this.ceza_tutarı_girişi.TextChanged += new System.EventHandler(this.ceza_tutarı_girişi_TextChanged);
            this.ceza_tutarı_girişi.Enter += new System.EventHandler(this.ceza_tutarı_girişi_Enter);
            this.ceza_tutarı_girişi.Leave += new System.EventHandler(this.ceza_tutarı_girişi_Leave);
            // 
            // sürücüler_liste
            // 
            this.sürücüler_liste.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sürücüler_liste.FormattingEnabled = true;
            this.sürücüler_liste.ItemHeight = 16;
            this.sürücüler_liste.Location = new System.Drawing.Point(691, 12);
            this.sürücüler_liste.Name = "sürücüler_liste";
            this.sürücüler_liste.Size = new System.Drawing.Size(192, 196);
            this.sürücüler_liste.TabIndex = 7;
            this.sürücüler_liste.SelectedIndexChanged += new System.EventHandler(this.sürücüler_liste_SelectedIndexChanged_1);
            this.sürücüler_liste.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.sürücüler_liste_MouseDoubleClick);
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
            this.sürücünün_cezaları.Location = new System.Drawing.Point(241, 328);
            this.sürücünün_cezaları.Name = "sürücünün_cezaları";
            this.sürücünün_cezaları.ReadOnly = true;
            this.sürücünün_cezaları.RowHeadersWidth = 51;
            this.sürücünün_cezaları.RowTemplate.Height = 24;
            this.sürücünün_cezaları.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sürücünün_cezaları.Size = new System.Drawing.Size(726, 210);
            this.sürücünün_cezaları.TabIndex = 8;
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
            // toplam_borç
            // 
            this.toplam_borç.AutoSize = true;
            this.toplam_borç.Location = new System.Drawing.Point(541, 291);
            this.toplam_borç.Name = "toplam_borç";
            this.toplam_borç.Size = new System.Drawing.Size(88, 16);
            this.toplam_borç.TabIndex = 10;
            this.toplam_borç.Text = "Toplam Borç:";
            this.toplam_borç.Click += new System.EventHandler(this.toplam_borç_Click);
            // 
            // btnCezayiSil
            // 
            this.btnCezayiSil.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCezayiSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCezayiSil.Location = new System.Drawing.Point(501, 259);
            this.btnCezayiSil.Name = "btnCezayiSil";
            this.btnCezayiSil.Size = new System.Drawing.Size(175, 29);
            this.btnCezayiSil.TabIndex = 11;
            this.btnCezayiSil.Text = "Cezayı Sil";
            this.btnCezayiSil.UseVisualStyleBackColor = false;
            this.btnCezayiSil.Click += new System.EventHandler(this.btnCezayiSil_Click);
            // 
            // btnAnaMenuyeDon
            // 
            this.btnAnaMenuyeDon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAnaMenuyeDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaMenuyeDon.Location = new System.Drawing.Point(13, 12);
            this.btnAnaMenuyeDon.Name = "btnAnaMenuyeDon";
            this.btnAnaMenuyeDon.Size = new System.Drawing.Size(140, 65);
            this.btnAnaMenuyeDon.TabIndex = 12;
            this.btnAnaMenuyeDon.Text = "Ana Menüye Dön";
            this.btnAnaMenuyeDon.UseVisualStyleBackColor = false;
            this.btnAnaMenuyeDon.Click += new System.EventHandler(this.btnAnaMenuyeDon_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1061, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 125);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PolisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1215, 644);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAnaMenuyeDon);
            this.Controls.Add(this.btnCezayiSil);
            this.Controls.Add(this.toplam_borç);
            this.Controls.Add(this.sürücünün_cezaları);
            this.Controls.Add(this.sürücüler_liste);
            this.Controls.Add(this.ceza_tutarı_girişi);
            this.Controls.Add(this.ceza_seçenek_seçimi);
            this.Controls.Add(this.sürücü_adı_girişi);
            this.Controls.Add(this.ceza_ekle);
            this.Controls.Add(this.sürücü_ekle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PolisFormu";
            this.Text = "PolisFormu";
            this.Load += new System.EventHandler(this.IOdenecekArayuz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sürücünün_cezaları)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sürücü_ekle;
        private System.Windows.Forms.Button ceza_ekle;
        private System.Windows.Forms.TextBox sürücü_adı_girişi;
        private System.Windows.Forms.ComboBox ceza_seçenek_seçimi;
        private System.Windows.Forms.TextBox ceza_tutarı_girişi;
        private System.Windows.Forms.ListBox sürücüler_liste;
        private System.Windows.Forms.DataGridView sürücünün_cezaları;
        private System.Windows.Forms.Label toplam_borç;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OdendiMi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surucu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn CezaTipi;
        private System.Windows.Forms.Button btnCezayiSil;
        private System.Windows.Forms.Button btnAnaMenuyeDon;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

