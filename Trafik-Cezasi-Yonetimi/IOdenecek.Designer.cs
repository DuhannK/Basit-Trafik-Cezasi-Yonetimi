namespace Trafik_Cezasi_Yonetimi
{
    partial class IOdenecek
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
            this.sürücü_ekle = new System.Windows.Forms.Button();
            this.ceza_ekle = new System.Windows.Forms.Button();
            this.ceza_öde = new System.Windows.Forms.Button();
            this.toplam_borç_görüntüle = new System.Windows.Forms.Button();
            this.sürücü_adı_girişi = new System.Windows.Forms.TextBox();
            this.ceza_seçenek_seçimi = new System.Windows.Forms.ComboBox();
            this.ceza_tutarı_girişi = new System.Windows.Forms.TextBox();
            this.sürücüler_liste = new System.Windows.Forms.ListBox();
            this.sürücünün_cezaları = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sürücünün_cezaları)).BeginInit();
            this.SuspendLayout();
            // 
            // sürücü_ekle
            // 
            this.sürücü_ekle.Location = new System.Drawing.Point(87, 12);
            this.sürücü_ekle.Name = "sürücü_ekle";
            this.sürücü_ekle.Size = new System.Drawing.Size(147, 23);
            this.sürücü_ekle.TabIndex = 0;
            this.sürücü_ekle.Text = "Sürücü Ekle\n\n";
            this.sürücü_ekle.UseVisualStyleBackColor = true;
            this.sürücü_ekle.Click += new System.EventHandler(this.sürücü_ekle_Click);
            // 
            // ceza_ekle
            // 
            this.ceza_ekle.Location = new System.Drawing.Point(87, 126);
            this.ceza_ekle.Name = "ceza_ekle";
            this.ceza_ekle.Size = new System.Drawing.Size(147, 23);
            this.ceza_ekle.TabIndex = 1;
            this.ceza_ekle.Text = "Ceza Ekle\n\n";
            this.ceza_ekle.UseVisualStyleBackColor = true;
            this.ceza_ekle.Click += new System.EventHandler(this.ceza_ekle_Click);
            // 
            // ceza_öde
            // 
            this.ceza_öde.Location = new System.Drawing.Point(87, 279);
            this.ceza_öde.Name = "ceza_öde";
            this.ceza_öde.Size = new System.Drawing.Size(147, 23);
            this.ceza_öde.TabIndex = 2;
            this.ceza_öde.Text = "Ceza Öde\n\n";
            this.ceza_öde.UseVisualStyleBackColor = true;
            this.ceza_öde.Click += new System.EventHandler(this.ceza_öde_Click);
            // 
            // toplam_borç_görüntüle
            // 
            this.toplam_borç_görüntüle.Location = new System.Drawing.Point(87, 325);
            this.toplam_borç_görüntüle.Name = "toplam_borç_görüntüle";
            this.toplam_borç_görüntüle.Size = new System.Drawing.Size(147, 23);
            this.toplam_borç_görüntüle.TabIndex = 3;
            this.toplam_borç_görüntüle.Text = "Toplam Borç Görüntüle\n\n";
            this.toplam_borç_görüntüle.UseVisualStyleBackColor = true;
            this.toplam_borç_görüntüle.Click += new System.EventHandler(this.toplam_borç_görüntüle_Click);
            // 
            // sürücü_adı_girişi
            // 
            this.sürücü_adı_girişi.Location = new System.Drawing.Point(52, 53);
            this.sürücü_adı_girişi.Name = "sürücü_adı_girişi";
            this.sürücü_adı_girişi.Size = new System.Drawing.Size(217, 22);
            this.sürücü_adı_girişi.TabIndex = 4;
            this.sürücü_adı_girişi.Tag = "";
            this.sürücü_adı_girişi.Text = "Ad Soyad";
            this.sürücü_adı_girişi.TextChanged += new System.EventHandler(this.sürücü_adı_girişi_TextChanged);
            // 
            // ceza_seçenek_seçimi
            // 
            this.ceza_seçenek_seçimi.FormattingEnabled = true;
            this.ceza_seçenek_seçimi.Items.AddRange(new object[] {
            "Hız",
            "Park",
            "Kırmızı Işık"});
            this.ceza_seçenek_seçimi.Location = new System.Drawing.Point(52, 203);
            this.ceza_seçenek_seçimi.Name = "ceza_seçenek_seçimi";
            this.ceza_seçenek_seçimi.Size = new System.Drawing.Size(217, 24);
            this.ceza_seçenek_seçimi.TabIndex = 5;
            this.ceza_seçenek_seçimi.Text = "Ceza Türünü Seçin";
            this.ceza_seçenek_seçimi.SelectedIndexChanged += new System.EventHandler(this.ceza_seçenek_seçimi_SelectedIndexChanged);
            // 
            // ceza_tutarı_girişi
            // 
            this.ceza_tutarı_girişi.Location = new System.Drawing.Point(52, 164);
            this.ceza_tutarı_girişi.Name = "ceza_tutarı_girişi";
            this.ceza_tutarı_girişi.Size = new System.Drawing.Size(217, 22);
            this.ceza_tutarı_girişi.TabIndex = 6;
            this.ceza_tutarı_girişi.Text = "Ceza Tutarı Giriniz";
            this.ceza_tutarı_girişi.TextChanged += new System.EventHandler(this.ceza_tutarı_girişi_TextChanged);
            // 
            // sürücüler_liste
            // 
            this.sürücüler_liste.FormattingEnabled = true;
            this.sürücüler_liste.ItemHeight = 16;
            this.sürücüler_liste.Location = new System.Drawing.Point(330, 12);
            this.sürücüler_liste.Name = "sürücüler_liste";
            this.sürücüler_liste.Size = new System.Drawing.Size(120, 164);
            this.sürücüler_liste.TabIndex = 7;
            // 
            // sürücünün_cezaları
            // 
            this.sürücünün_cezaları.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sürücünün_cezaları.Location = new System.Drawing.Point(473, 12);
            this.sürücünün_cezaları.Name = "sürücünün_cezaları";
            this.sürücünün_cezaları.RowHeadersWidth = 51;
            this.sürücünün_cezaları.RowTemplate.Height = 24;
            this.sürücünün_cezaları.Size = new System.Drawing.Size(166, 164);
            this.sürücünün_cezaları.TabIndex = 8;
            this.sürücünün_cezaları.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sürücünün_cezaları_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Toplam Borç:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // IOdenecek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sürücünün_cezaları);
            this.Controls.Add(this.sürücüler_liste);
            this.Controls.Add(this.ceza_tutarı_girişi);
            this.Controls.Add(this.ceza_seçenek_seçimi);
            this.Controls.Add(this.sürücü_adı_girişi);
            this.Controls.Add(this.toplam_borç_görüntüle);
            this.Controls.Add(this.ceza_öde);
            this.Controls.Add(this.ceza_ekle);
            this.Controls.Add(this.sürücü_ekle);
            this.Name = "IOdenecek";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sürücünün_cezaları)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sürücü_ekle;
        private System.Windows.Forms.Button ceza_ekle;
        private System.Windows.Forms.Button ceza_öde;
        private System.Windows.Forms.Button toplam_borç_görüntüle;
        private System.Windows.Forms.TextBox sürücü_adı_girişi;
        private System.Windows.Forms.ComboBox ceza_seçenek_seçimi;
        private System.Windows.Forms.TextBox ceza_tutarı_girişi;
        private System.Windows.Forms.ListBox sürücüler_liste;
        private System.Windows.Forms.DataGridView sürücünün_cezaları;
        private System.Windows.Forms.Label label1;
    }
}

