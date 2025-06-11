using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Trafik_Cezasi_Yonetimi
{

    public partial class PolisFormu : Form
    {
        List<Surucu> suruculer;
        public PolisFormu(List<Surucu> suruculer)
        {
            InitializeComponent();
            this.suruculer = suruculer;

            sürücü_adı_girişi.Text = "Ad Soyad";
            sürücü_adı_girişi.ForeColor = Color.Gray;

            ceza_tutarı_girişi.Text = "Ceza Tutarı Giriniz";
            ceza_tutarı_girişi.ForeColor = Color.Gray;

            ceza_seçenek_seçimi.Items.Clear();
            ceza_seçenek_seçimi.Items.Add("Ceza Türü Seçin");
            ceza_seçenek_seçimi.Items.Add("Hız");
            ceza_seçenek_seçimi.Items.Add("Park");
            ceza_seçenek_seçimi.Items.Add("Kırmızı Işık");
            ceza_seçenek_seçimi.SelectedIndex = 0;

            sürücüler_liste.DataSource = null;
            sürücüler_liste.DataSource = suruculer;
        }

        private void sürücü_adı_girişi_Enter(object sender, EventArgs e)
        {
            if (sürücü_adı_girişi.Text == "Ad Soyad")
            {
                sürücü_adı_girişi.Text = "";
                sürücü_adı_girişi.ForeColor = Color.Black;
            }
        }

        private void sürücü_adı_girişi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sürücü_adı_girişi.Text))
            {
                sürücü_adı_girişi.Text = "Ad Soyad";
                sürücü_adı_girişi.ForeColor = Color.Black;
            }
        }

        private void ceza_tutarı_girişi_Enter(object sender, EventArgs e)
        {
            if (ceza_tutarı_girişi.Text == "Ceza Tutarı Giriniz")
            {
                ceza_tutarı_girişi.Text = "";
                ceza_tutarı_girişi.ForeColor = Color.Black;
            }
        }

        private void ceza_tutarı_girişi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ceza_tutarı_girişi.Text))
            {
                ceza_tutarı_girişi.Text = "Ceza Tutarı Giriniz";
                ceza_tutarı_girişi.ForeColor = Color.Black;
            }
        }


        private void sürücü_ekle_Click(object sender, EventArgs e)
        {
            string ad = sürücü_adı_girişi.Text.Trim();
            if (!string.IsNullOrEmpty(ad))
            {
                var surucu = new Surucu(suruculer.Count + 1, ad);
                suruculer.Add(surucu);
                sürücüler_liste.DataSource = null;
                sürücüler_liste.DataSource = suruculer;
                sürücü_adı_girişi.Text = "Ad Soyad";
                sürücü_adı_girişi.ForeColor = Color.Gray;
            }
        }

        private void ceza_ekle_Click(object sender, EventArgs e)
        {
            var seciliSurucu = sürücüler_liste.SelectedItem as Surucu;
            if (seciliSurucu == null) return;

            if (!decimal.TryParse(ceza_tutarı_girişi.Text, out decimal tutar) || tutar <= 0)
            {
                MessageBox.Show("Geçerli bir ceza tutarı girin.");
                return;
            }

            if (ceza_seçenek_seçimi.SelectedIndex <= 0) // 0 = "Ceza Türü Seçin"
            {
                MessageBox.Show("Lütfen geçerli bir ceza türü seçin.");
                return;
            }

            CezaTuru seciliCezaTuru = (CezaTuru)(ceza_seçenek_seçimi.SelectedIndex - 1);
            Ceza yeniCeza = null;
            if (seciliCezaTuru == CezaTuru.Hiz)
                yeniCeza = new HizCeza(tutar, DateTime.Now, seciliSurucu);
            else if (seciliCezaTuru == CezaTuru.Park)
                yeniCeza = new ParkCeza(tutar, DateTime.Now, seciliSurucu);
            else if (seciliCezaTuru == CezaTuru.KirmiziIsik)
                yeniCeza = new KirmiziIsikCeza(tutar, DateTime.Now, seciliSurucu);

            if (yeniCeza != null)
            {
                seciliSurucu.Cezalar.Add(yeniCeza);
            }
            CezalariGoster();
        }


        private void toplam_borç_görüntüle_Click(object sender, EventArgs e)
        {
            var seciliSurucu = sürücüler_liste.SelectedItem as Surucu;
            if (seciliSurucu != null)
            {
                toplam_borç.Text = "Toplam Borç: " + seciliSurucu.ToplamBorc() + " TL";
            }
        }

        private void sürücüler_liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            CezalariGoster();
        }

        private void CezalariGoster()
        {
            var seciliSurucu = sürücüler_liste.SelectedItem as Surucu;
            if (seciliSurucu != null)
            {
                // Sadece ödenmemiş cezalar için
                sürücünün_cezaları.DataSource = null;
                sürücünün_cezaları.DataSource = seciliSurucu.Cezalar.Where(c => !c.OdendiMi).ToList();
                toplam_borç.Text = "Toplam Borç: " + seciliSurucu.ToplamBorc() + " TL";
            }
            else
            {
                sürücünün_cezaları.DataSource = null;
                toplam_borç.Text = "Toplam Borç: ";
            }
        }

        private void sürücü_adı_girişi_TextChanged(object sender, EventArgs e)
        {

        }

        private void ceza_seçenek_seçimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ceza_seçenek_seçimi.SelectedIndex == -1)
            {
                ceza_seçenek_seçimi.Items.Insert(0, "Ceza Türü Seçin");
                ceza_seçenek_seçimi.SelectedIndex = 0;
            }
        }

        private void ceza_tutarı_girişi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sürücünün_cezaları_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IOdenecekArayuz_Load(object sender, EventArgs e)
        {

            ceza_seçenek_seçimi.DropDownStyle = ComboBoxStyle.DropDownList;

            ceza_seçenek_seçimi.Items.Clear();
            ceza_seçenek_seçimi.Items.Add("Ceza Türü Seçin");
            ceza_seçenek_seçimi.Items.AddRange(Enum.GetNames(typeof(CezaTuru)));
            ceza_seçenek_seçimi.SelectedIndex = 0;

        }

        private void toplam_borç_Click(object sender, EventArgs e)
        {

        }
        private void ceza_seçenek_seçimi_DropDown(object sender, EventArgs e)
        {
            if (ceza_seçenek_seçimi.Items.Contains("Ceza Türü Seçin"))
            {
                ceza_seçenek_seçimi.Items.Remove("Ceza Türü Seçin");
            }
        }


        private void sürücüler_liste_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var seciliSurucu = sürücüler_liste.SelectedItem as Surucu;
            if (seciliSurucu != null)
            {
                sürücünün_cezaları.DataSource = null;
                sürücünün_cezaları.DataSource = seciliSurucu.Cezalar;
                toplam_borç.Text = "Toplam Borç: " + seciliSurucu.ToplamBorc() + " TL";
            }
        }

        private void btnCezayiSil_Click(object sender, EventArgs e)
        {
            var seciliSurucu = sürücüler_liste.SelectedItem as Surucu;
            if (seciliSurucu == null || sürücünün_cezaları.SelectedRows.Count == 0) return;
            Ceza ceza = sürücünün_cezaları.SelectedRows[0].DataBoundItem as Ceza;
            if (ceza != null)
            {
                seciliSurucu.Cezalar.Remove(ceza);
                CezalariGoster();
            }
        }

        private void btnAnaMenuyeDon_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void sürücüler_liste_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

// Deneme 
