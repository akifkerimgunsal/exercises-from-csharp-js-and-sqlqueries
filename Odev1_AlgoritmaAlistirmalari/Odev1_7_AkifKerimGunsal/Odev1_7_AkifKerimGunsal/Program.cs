namespace Odev1_7_AkifKerimGunsal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç öğrenci için not girmek istiyorsunuz: ");
            int ogrenciSayisi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= ogrenciSayisi; i++)
            {
                Console.Clear();
                Console.WriteLine(i + ". öğrenci için bilgileri giriniz:");

                Console.Write("Öğrenci adı: ");
                string ad = Console.ReadLine();

                Console.Write("Öğrenci soyadı: ");
                string soyad = Console.ReadLine();

                Console.Write("1. sınav notu: ");
                double not1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("2. sınav notu: ");
                double not2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("3. sınav notu: ");
                double not3 = Convert.ToDouble(Console.ReadLine());

                double ortalama = (not1 + not2 + not3) / 3;

                Console.WriteLine(ad + " " + soyad + " için not ortalaması: " + ortalama);
                Console.Write("Başka bir öğrenci ve not hesabı için herhangi bir tuşa basınız.");
                Console.ReadKey();

            }
        }
    }
}
