namespace Odev_String
{
    internal class Program
    {
        static bool AyracMi(char karakter)
        {
            string Ayraclar = " /*-+,#$:;";
            bool sonuc = false;
            for (int i = 0; i < Ayraclar.Length; i++)
            {
                char ayrac = Ayraclar[i];
                if (ayrac == karakter)
                {
                    sonuc = true;
                    break;
                }
            }
            return sonuc;
        }
        
        static void Main(string[] args)
        {
            string yazi = "Kadiköy /   istanbul-Turkiye";

            int BoslukSayisi = 0;
            int KelimeSayisi = 0;

            yazi = yazi.Trim();
            if (yazi.Length > 0)
            {
                Console.WriteLine(yazi);

                for (int i = 0; i < yazi.Length; i++)
                {
                    if (AyracMi(yazi[i]) && !AyracMi(yazi[i - 1]))
                        BoslukSayisi++;
                }
                KelimeSayisi = BoslukSayisi + 1;
                Console.WriteLine(KelimeSayisi);
            }

            else
                Console.WriteLine(KelimeSayisi);
        }
    }
}