namespace Odev1_2_AkifKerimGunsal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç ürün almak istediğinizi giriniz: ");
            int urunAdedi;
            double toplamTutar = 0;
            if (int.TryParse(Console.ReadLine(), out urunAdedi) && urunAdedi > 0)
            {
                for (int i = 1; i <= urunAdedi; i++)
                {
                    Console.WriteLine($"Ürün {i} fiyatını giriniz: ");
                    if (double.TryParse(Console.ReadLine(), out double urunFiyati) && urunFiyati > 0)
                    {
                        toplamTutar += urunFiyati;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz fiyat girişi. Lütfen geçerli bir fiyat girin.");
                        i--;
                    }
                }

                Console.WriteLine("Toplam alışveriş tutarı: " + toplamTutar);
            }
            else
            {
                Console.WriteLine("Geçersiz ürün adedi girişi. Lütfen geçerli bir sayı girin.");
            }
        }
    }
}
