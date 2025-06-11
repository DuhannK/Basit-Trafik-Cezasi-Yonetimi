namespace Trafik_Cezasi_Yonetimi
{
    public interface IOdenecek
    {
        void OdemeYap();
        bool OdendiMi { get; }
        decimal GetirTutar();
        string RaporOlustur();
    }
}
