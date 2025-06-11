using System;
using Trafik_Cezasi_Yonetimi;

public abstract class Ceza : IOdenecek
{
    public bool OdendiMi { get; private set; }
    public Surucu Surucu { get; set; }
    public decimal Tutar { get; set; }
    public DateTime Tarih { get; set; }
    public CezaTuru CezaTuru { get; set; }

    public string CezaTuruAdi
    {
        get { return CezaTuru.ToString(); }
    }

    public Ceza(decimal tutar, DateTime tarih, Surucu surucu, CezaTuru cezaTuru)
    {
        this.Tutar = tutar;
        this.Tarih = tarih;
        this.Surucu = surucu;
        this.OdendiMi = false;
        this.CezaTuru = cezaTuru;
    }

    public void OdemeYap()
    {
        OdendiMi = true;
    }

    public decimal GetirTutar()
    {
        return Tutar;
    }

    public string RaporOlustur()
    {
        return $"Sürücü: {Surucu.AdSoyad} | Tutar: {Tutar} TL | Tarih: {Tarih.ToShortDateString()} | Ceza Türü: {CezaTuru} | Ödendi mi: {OdendiMi}";
    }
}
