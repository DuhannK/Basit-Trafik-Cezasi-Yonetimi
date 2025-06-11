using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Trafik_Cezasi_Yonetimi
{
    public partial class AnaMenu : Form
    {
        private List<Surucu> suruculer = new List<Surucu>();

        public AnaMenu()
        {
            InitializeComponent();
        }

        private void btnCezaSorgulama_Click(object sender, EventArgs e)
        {
            KullaniciFormu kullaniciForm = new KullaniciFormu(suruculer);
            kullaniciForm.Owner = this;
            kullaniciForm.Show();
            this.Hide();
        }

        private void btnCezaIslemleri_Click(object sender, EventArgs e)
        {
            PolisFormu polisForm = new PolisFormu(suruculer);
            polisForm.Owner = this;
            polisForm.Show();
            this.Hide();
        }
    }

}
