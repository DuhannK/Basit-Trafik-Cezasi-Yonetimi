﻿//Enum ve kalıtım kullanıldı
using System;

namespace Trafik_Cezasi_Yonetimi
{
    public class KirmiziIsikCeza : Ceza
    {
        public KirmiziIsikCeza(decimal tutar, DateTime tarih, Surucu surucu)
            : base(tutar, tarih, surucu, CezaTuru.KirmiziIsik) { }
    }
}
