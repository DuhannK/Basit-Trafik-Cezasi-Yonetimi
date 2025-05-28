using System;

namespace Trafik_Cezasi_Yonetimi
{
    public class ParkCeza : Ceza
    {
        public ParkCeza(decimal tutar, DateTime tarih, Surucu surucu)
            : base(tutar, tarih, surucu) { }

        public override string CezaTipi => "Park";
    }
}
