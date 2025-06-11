//Enum ve kalıtım kullanıldı
using System;

namespace Trafik_Cezasi_Yonetimi
{
    public class HizCeza : Ceza
    {
        public HizCeza(decimal tutar, DateTime tarih, Surucu surucu)
            : base(tutar, tarih, surucu, CezaTuru.Hiz) { }
    }
}
