using System;

namespace hata_yonetimi
{

    class Program
    {
        static void Main(string [] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());

               
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı");
            }

            try
            {
                int a = int.Parse(null);
                int b = int.Parse("test");
                int c = int.Parse("-20000000000000000");

            }
            catch (ArgumentException aex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(aex);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch (OverflowException oex)
            {
                Console.WriteLine("Çok büyük ya da ok küçük bir sayı girdiniz");
                Console.WriteLine(oex);
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı");
            }
        }
    }
}