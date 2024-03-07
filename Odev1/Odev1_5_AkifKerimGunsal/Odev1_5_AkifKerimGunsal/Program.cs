namespace Odev1_5_AkifKerimGunsal
{
    internal class Program
    {
        static bool mukemmelSayiKontrol(int num)
        {
            int toplam = 0;

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    toplam += i;
                }
            }

            return toplam == num;
        }

        static void Main(string[] args)
        {
            Console.Write("Bir sayı girin: ");

            int sayi = Convert.ToInt32(Console.ReadLine());

            if (mukemmelSayiKontrol(sayi))
            {
                Console.WriteLine(sayi + " mükemmel bir sayıdır.");
            }
            else
            {
                Console.WriteLine(sayi + " mükemmel bir sayı değildir.");
            }
        }
    }
}
