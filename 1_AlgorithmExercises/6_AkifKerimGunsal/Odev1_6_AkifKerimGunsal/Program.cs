namespace Odev1_6_AkifKerimGunsal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ornekMetin = "Tobeto'ya Hoşgeldiniz";

            string trim = ornekMetin.Trim(); // Başındaki ve sonundaki boşlukları kaldırır
            string upperCase = ornekMetin.ToUpper(); // Tüm harfleri büyük harfe dönüştürür
            string lowerCase = ornekMetin.ToLower(); // Tüm harfleri küçük harfe dönüştürür
            string replaced = ornekMetin.Replace("Tobeto'ya", "C#'a"); // Belirli bir kısmı, istediğimiz bir metin ile değiştirebiliriz.
            string substring = ornekMetin.Substring(8, 7); // Belirtilen başlangıç indeksinden itibaren belirli bir sayıda karakter içeren alt bir metin döndürür
            string[] split = ornekMetin.Split('o'); // Belirli bir ayraç kullanarak metni parçalar ve alt metinleri döndürür

            Console.WriteLine("Örnek metinimiz: \"" + ornekMetin + "\"");
            Console.WriteLine("Trim sonrası: \"" + trim + "\"");
            Console.WriteLine("Upper Case sonrası: \"" + upperCase + "\"");
            Console.WriteLine("Lower Case sonrası: \"" + lowerCase + "\"");
            Console.WriteLine("Replaced sonrası: \"" + replaced + "\"");
            Console.WriteLine("Substring sonrası: \"" + substring + "\"");
            Console.WriteLine("Split sonrası:");
            foreach (var item in split)
            {
                Console.WriteLine(item.Trim());
            }

            //Çok daha fazla string metodu mevcut ancak sık kullanılanlar olarak bunlar için örnek verebiliriz.
        }
    }
}
