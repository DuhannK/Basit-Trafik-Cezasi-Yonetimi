using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trafik_Cezasi_Yonetimi
{

    public partial class IOdenecekArayuz : Form
    {
        // Sınıf Listesi burada!
        List<Surucu> suruculer = new List<Surucu>();

        public IOdenecekArayuz()
        {
            InitializeComponent();
        }

        private void sürücü_ekle_Click(object sender, EventArgs e)
        {
            string ad = sürücü_adı_girişi.Text.Trim();
            if (!string.IsNullOrEmpty(ad))
            {
                var surucu = new Surucu(suruculer.Count + 1, ad);
                suruculer.Add(surucu);
                sürücüler_liste.Items.Add(surucu);
                sürücü_adı_girişi.Clear();
            }
        }

        private void ceza_ekle_Click(object sender, EventArgs e)
        {
            var seciliSurucu = sürücüler_liste.SelectedItem as Surucu;
            if (seciliSurucu == null) return;

            string cezaTuru = ceza_seçenek_seçimi.SelectedItem?.ToString();
            if (cezaTuru == null || cezaTuru == "Ceza Türü Seçin") // 💡 Kontrol burada
            {
                MessageBox.Show("Lütfen geçerli bir ceza türü seçin.");
                return;
            }

            if (!decimal.TryParse(ceza_tutarı_girişi.Text, out decimal tutar) || tutar <= 0)
            {
                MessageBox.Show("Geçerli bir ceza tutarı girin.");
                return;
            }

            Ceza yeniCeza = null;
            if (cezaTuru == "Hız")
                yeniCeza = new HizCeza(tutar, DateTime.Now, seciliSurucu);
            else if (cezaTuru == "Park")
                yeniCeza = new ParkCeza(tutar, DateTime.Now, seciliSurucu);
            else if (cezaTuru == "Kırmızı Işık")
                yeniCeza = new KirmiziIsikCeza(tutar, DateTime.Now, seciliSurucu);

            if (yeniCeza != null)
            {
                seciliSurucu.Cezalar.Add(yeniCeza);
                sürücüler_liste_SelectedIndexChanged(null, null); // Listeyi yenile
                ceza_tutarı_girişi.Clear();
            }
        }


        private void ceza_öde_Click(object sender, EventArgs e)
        {
            var seciliSurucu = sürücüler_liste.SelectedItem as Surucu;
            if (seciliSurucu == null) return;

            if (sürücünün_cezaları.SelectedRows.Count > 0)
            {
                var ceza = sürücünün_cezaları.SelectedRows[0].DataBoundItem as Ceza;
                ceza?.OdemeYap();
                // Listeyi yenile
                sürücüler_liste_SelectedIndexChanged(null, null);
            }
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
            var seciliSurucu = sürücüler_liste.SelectedItem as Surucu;
            if (seciliSurucu != null)
            {
                sürücünün_cezaları.DataSource = null;
                sürücünün_cezaları.DataSource = seciliSurucu.Cezalar;
                toplam_borç.Text = "Toplam Borç: " + seciliSurucu.ToplamBorc() + " TL";
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
            ceza_seçenek_seçimi.Items.Add("Ceza Türü Seçin"); // Rehber yazı
            ceza_seçenek_seçimi.Items.Add("Kırmızı Işık");
            ceza_seçenek_seçimi.Items.Add("Hız");
            ceza_seçenek_seçimi.Items.Add("Park");

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

    }
}

// Deneme 
