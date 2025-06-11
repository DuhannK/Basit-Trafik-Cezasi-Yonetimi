using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Trafik_Cezasi_Yonetimi
{
    public partial class KullaniciFormu : Form
    {
        List<Surucu> suruculer;
        Surucu seciliSurucu;

        public KullaniciFormu(List<Surucu> suruculer)
        {
            InitializeComponent();
            this.suruculer = suruculer;
            sadece_ödenmemiş_checkbox.Checked = false;
        }
        private void btnSorgula_Click(object sender, EventArgs e)
        {
            string isim = kullanici_ad_giris.Text.Trim();
            seciliSurucu = suruculer.FirstOrDefault(x => x.AdSoyad.Equals(isim, StringComparison.InvariantCultureIgnoreCase));
            if (seciliSurucu == null)
            {
                MessageBox.Show("Böyle bir sürücü bulunamadı.");
                sürücünün_cezaları.DataSource = null;
                toplam_borç.Text = "Toplam Borç: ";
                return;
            }
            CezalariListele();
        }
        
        private void sadece_ödenmemiş_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CezalariListele();
        }

        void CezalariListele()
        {
            if (seciliSurucu == null) return;
            if (sadece_ödenmemiş_checkbox.Checked)
                sürücünün_cezaları.DataSource = seciliSurucu.Cezalar.Where(c => !c.OdendiMi).ToList();
            else
                sürücünün_cezaları.DataSource = seciliSurucu.Cezalar.ToList();

            toplam_borç.Text = "Toplam Borç: " + seciliSurucu.Cezalar.Where(c => !c.OdendiMi).Sum(c => c.Tutar) + " TL";
        }

        private void ceza_öde_Click(object sender, EventArgs e)
        {
            if (seciliSurucu == null || sürücünün_cezaları.SelectedRows.Count == 0) return;
            Ceza ceza = sürücünün_cezaları.SelectedRows[0].DataBoundItem as Ceza;
            if (ceza != null && !ceza.OdendiMi)
            {
                ceza.OdemeYap();
                CezalariListele();
            }
        }
        private void tüm_cezaları_öde_Click(object sender, EventArgs e)
        {
            if (seciliSurucu == null) return;
            foreach (var ceza in seciliSurucu.Cezalar.Where(c => !c.OdendiMi))
                ceza.OdemeYap();
            CezalariListele();
        }

        private void kullanici_ad_giris_TextChanged(object sender, EventArgs e)
        {

        }


        private void toplam_borç_Click(object sender, EventArgs e)
        {

        }


        private void sürücünün_cezaları_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAnaMenuyeDon_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void sadece_ödenmemiş_checkbox_CheckedChanged_1(object sender, EventArgs e)
        {
            CezalariListele();
        }
    }
}
