namespace Odev1_4_AkifKerimGunsal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Tahmin Oyunu");
            Random random = new Random();
            int rastgeleSayi = random.Next(1, 11);

            int tahmin = 0;
            int denemeSayisi = 0;

            while (tahmin != rastgeleSayi)
            {
                Console.Write("1 ile 10 arasında bir sayı tahmin edin.: ");
                if (int.TryParse(Console.ReadLine(), out tahmin))
                {
                    if (tahmin < 1 || tahmin > 10)
                    {
                        Console.WriteLine("Lütfen 1 ile 10 arasında bir sayı girin.");
                        continue;
                    }

                    denemeSayisi++;

                    if (tahmin < rastgeleSayi)
                    {
                        Console.WriteLine("Daha büyük bir sayı girin.");
                    }
                    else if (tahmin > rastgeleSayi)
                    {
                        Console.WriteLine("Daha küçük bir sayı girin.");
                    }
                    else
                    {
                        Console.WriteLine("Tebrikler! " + denemeSayisi + ". denemede doğru sayıyı tahmin ettiniz.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
                }
            }
        }
    }
}
