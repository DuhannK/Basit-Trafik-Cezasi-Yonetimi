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
            decimal tutar = 0;
            decimal.TryParse(ceza_tutarı_girişi.Text, out tutar);

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
                // Listeyi yenile
                sürücüler_liste_SelectedIndexChanged(null, null);
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

        }

        private void toplam_borç_Click(object sender, EventArgs e)
        {

        }
    }
}

// Deneme 
