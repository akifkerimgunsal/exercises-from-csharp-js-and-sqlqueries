namespace Odev1_3_AkifKerimGunsal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;

            // While döngüsü 
            Console.WriteLine("While döngüsü örneği:");
            while (sayac < 0)
            {
                Console.WriteLine("Sayac değeri: " + sayac);
                sayac++;
            }

            sayac = 0; // Sayacı sıfırlayalım

            // Do-While döngüsü 
            Console.WriteLine("\nDo-While döngüsü örneği:");
            do
            {
                Console.WriteLine("Sayac değeri: " + sayac);
                sayac++;
            } while (sayac < 0);

            /*Örnekte de görüleceği üzere While döngüsünde önce koşulun sağlanıp sağlanmadığına
            bakılarak döngü içerisine giriş yapılır. Do-while döngüsünde ise koşula 
            bakılmaksızın döngüye 1 kere giriş yapılır ardından koşul kontrolü sağlanır. */
        }
    }
}
