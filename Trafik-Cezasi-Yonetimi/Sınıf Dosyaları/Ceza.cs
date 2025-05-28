using System;

namespace Trafik_Cezasi_Yonetimi
{
    public abstract class Ceza : IOdenecekArayuz
    {
        public bool OdendiMi { get; private set; }
        public Surucu Surucu { get; set; }
        public decimal Tutar { get; set; }
        public DateTime Tarih { get; set; }

        public Ceza(decimal tutar, DateTime tarih, Surucu surucu)
        {
            this.Tutar = tutar;
            this.Tarih = tarih;
            this.Surucu = surucu;
            this.OdendiMi = false;
        }

        public void OdemeYap()
        {
            OdendiMi = true;
        }

        public abstract string CezaTipi { get; }
    }
}
