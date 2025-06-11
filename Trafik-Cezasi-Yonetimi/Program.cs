using System.Windows.Forms;

namespace Trafik_Cezasi_Yonetimi
{
    internal static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnaMenu());
        }
    }
}
