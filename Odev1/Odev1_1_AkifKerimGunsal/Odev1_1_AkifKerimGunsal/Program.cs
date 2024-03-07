using System.Runtime.CompilerServices;

namespace Odev1_1_AkifKerimGunsal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İçecek Otomatına Hoşgeldiniz\n----------------------------");
            Console.WriteLine("Su için: 1\nKola için: 2\nMaden suyu için: 3\nSoğuk Kahve için: 4");
            Console.Write("Sipariş numarasını giriniz: ");
            string siparisNumarasi = Console.ReadLine();

            switch (Convert.ToInt32(siparisNumarasi))
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Su sipariş edildi.");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Kola sipariş edildi.");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Maden Suyu sipariş edildi.");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Soğuk Kahve sipariş edildi.");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Geçersiz sipariş numarası.");
                    break;
            }
        }
    }
}
