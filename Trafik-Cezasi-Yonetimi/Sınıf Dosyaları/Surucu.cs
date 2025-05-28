using System.Collections.Generic;
using System.Linq;

namespace Trafik_Cezasi_Yonetimi
{
    public class Surucu
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public List<Ceza> Cezalar { get; set; } = new List<Ceza>();

        public Surucu(int id, string adSoyad)
        {
            Id = id;
            AdSoyad = adSoyad;
        }

        // Toplam borç (ödenmemiş cezalar toplamı)
        public decimal ToplamBorc()
        {
            return Cezalar.Where(c => !c.OdendiMi).Sum(c => c.Tutar);
        }

        public override string ToString()
        {
            return AdSoyad;
        }
    }
}
