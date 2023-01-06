using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Diziler tek tür değişken olarak oluşturulabilir, örnek olarak string bir dizin oluşturduğunuzda içine bir int değer atayamazsınız.
            // Dizilerin sayımı (indeksi) 0'dan başlar, yani 1. değişkenin sayı değeri 0'dır. 5. değişkenin sayı değeri 4'tür.

            // Dizi tanımlama örnekleri
            string[] dizin1 = {"Cenker","Sipahi","2023"};   // Bu şekilde direkt elemanları yazarak tanımlayabilirsiniz.

            string[] dizin2 = new string[7];                // Bu şekilde 7 stringden oluşan dizin2 isimli bir dizin tanımladık.
                                                            // (Şu anda bu stringin içi boş değerlerini sonradan girmeliyiz.)

            int[] dizin3;                                   // Bu şekilde de önce dizin oluşturup sonra içinde kaç tane değer bulunacağını belirtebiliriz.
            dizin3 = new int[7];                            // (Şu anda bu stringin içi boş değerlerini sonradan girmeliyiz.)


            // Dizilere atama yapma örnekleri.
            dizin2[0] = "Sipahi";                           // Burada dizin2 dizinindeki ilk değişkene Sipahi değerini vermiş olduk.

            dizin3[5] = 2023;                               // Burada aynı şekilde dizin3'teki 4. değişkene 2023 değerini vermiş olduk.


            // Dizilere erişme.
            Console.Write(dizin1[0]);                       // Burada dizin1 içinde bulunan indeksi 0 olan değeri, yani Cenker yazısını konsola yazacak.

            Console.Write(dizin2[0]);                       // Burada dizin2 içinde bulunan indeksi 0 olan değeri, yani Sipahi yazısını konsola yazacak.

            Console.WriteLine(dizin3[5]);                   // Burada dizin3 içinde bulunan indeksi 5 olan değeri, yani 2023 yazısını konsola yazacak.


            // Örnekler

            // Klavyeden girilen n tane sayının ortalaması.
            Console.Write("Lütfen dizinin büyüklüğünü belirtiniz: ");
            int n = int.Parse(Console.ReadLine());                                  // Burada dizinin uzunluğunu alıyoruz.
            float ortalama;
            float toplam = 0;

            int[] sayilar = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("İndeksi "+ i +" olan sayıyı giriniz : ");    
                sayilar[i] = int.Parse(Console.ReadLine());                         // Burada dizinin değerlerini alıyoruz.
            }

            foreach (var sayi in sayilar)                                           // foreach kullanıyoruz çünkü dizinler içinde gidebilen döngü bu.          
            {
                toplam += sayi;                                                     // Dizinin içindeki sayıları topluyoruz.
            }

            ortalama = toplam / n;                                                  // Ortalama hesabı.
            Console.WriteLine("Girdiğiniz sayıların ortalaması : {0}", ortalama);   // Yazdırma.
            Console.WriteLine("");


            // Array sınıfı ve metodları
            // Array.Sort adından da anlaşılabileceği üzere, dizin içindeki değerleri sıralar.
            // Array.Clear dizinin belli bir indeksinden başlayarak belirli kadar elemanı varsayılana sıfırlar, örneğin sayısal değerleri 0'a çevirir.
            // Array.Reverse dizinin içindeki tüm ilk ve son değerlerin yerlerini değiştirir. 5 değer varsa 1. 5'in yerine 2. 4'ün yerine gibi.
            // Array.IndexOf verilen elemanın indeksini getirir, eğer içi boşsa -1 değerini verir.
            // Array.Resize dizileri yeniden boyutlandırır.


            // Örnekler

            // Array.Sort örneği:
            Console.WriteLine("***Array.Sort örneği:***");

            int[] dizi9 = {72, 36, 42, 89, 90, 101};
            Console.WriteLine("");                          // BOŞLUK İÇİN, ÖNEMSEME.
            Console.WriteLine("**Sıralanmamış Hali**");
            foreach (var sayi in dizi9)                     // Dizilerde foreach kullanılır.
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("");                          // BOŞLUK İÇİN, ÖNEMSEME.
            Array.Sort(dizi9);                              // Burada dizi9'u sıralıyor.
            Console.WriteLine("**Sıralanmış Hali**");
            foreach (var sayi in dizi9)                     // Dizilerde foreach kullanılır.
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("");                          // BOŞLUK İÇİN, ÖNEMSEME.

            // Array.Clear örneği:
            Console.WriteLine("***Array.Clear örneği:***");
            Console.WriteLine("");                          // BOŞLUK İÇİN, ÖNEMSEME.

            int[] dizi8 = {8, 3, 90, 23, 65, 12};
            Array.Clear(dizi8, 1, 3);                       // Burada indeksi 1 olan elemandan başlayıp (o eleman da dahil) sonraki 3 elemanı siliyor.
            foreach (var sayi in dizi8)                     // Dizilerde foreach kullanılır.
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("");                          // BOŞLUK İÇİN, ÖNEMSEME.

            // Array.Reverse örneği:
            Console.WriteLine("***Array.Reverse örneği:***");
            Console.WriteLine("");                          // BOŞLUK İÇİN, ÖNEMSEME.

            int[] dizi7 = {1, 2, 3, 4, 5};
            Console.WriteLine("Çevirilmeden önceki hali :");
            Console.WriteLine("");                          // BOŞLUK İÇİN, ÖNEMSEME.
            foreach (var sayi in dizi7)                     // Dizilerde foreach kullanılır.
                Console.WriteLine(sayi);

            Array.Reverse(dizi7);                           // Burada dizini tersine çeviriyor, konsolda daha rahat görebilirsiniz.
            Console.WriteLine("");                          // BOŞLUK İÇİN, ÖNEMSEME.
            Console.WriteLine("Çevirildikten sonraki hali :");
            Console.WriteLine("");                          // BOŞLUK İÇİN, ÖNEMSEME.
            foreach (var sayi in dizi7)                     // Dizilerde foreach kullanılır.
                Console.WriteLine(sayi);

            Console.WriteLine("");                          // BOŞLUK İÇİN, ÖNEMSEME.

            // Array.IndexOf örneği:
            Console.WriteLine("***Array.IndexOf örneği:***");
            Console.WriteLine("");                          // BOŞLUK İÇİN, ÖNEMSEME.

            int[] dizi6 = {42, 56, 64, 76, 88};
            Console.WriteLine(Array.IndexOf(dizi6, 56));    // 56 sayısının indeksini (yani 1) ekrana yazdırıyor.

            Console.WriteLine("");                          // BOŞLUK İÇİN, ÖNEMSEME.

            // Array.Resize örneği:                         // Array.Resize dan sonra gelen < > sembolü arasına dizinimizin türünü yazıyoruz.
            Console.WriteLine("***Array.Resize örneği:***");
            Console.WriteLine("");                          // BOŞLUK İÇİN, ÖNEMSEME.

            int[] dizi5 = {10, 11, 12, 13, 14, 15};
            Console.WriteLine("**İlk Hali**");
            Console.WriteLine("");

            foreach (var sayi in dizi5)                     // Dizilerde foreach kullanılır.
                Console.WriteLine(sayi);

            Console.WriteLine("");                          // BOŞLUK İÇİN, ÖNEMSEME.

            Array.Resize<int>(ref dizi5, 7);                // Burada eleman sayısı 6 olan dizinimizi 7'ye çıkarıyoruz.
            dizi5[6] = 16;                                  // Az önce eleman sayısını 1 arttırdığımız için boş olmasın diye son elemana değer veriyoruz.
            Console.WriteLine("**Arttırılmış Hali*");
            Console.WriteLine("");                          // BOŞLUK İÇİN, ÖNEMSEME.

            foreach (var sayi in dizi5)                     // Dizilerde foreach kullanılır.
                Console.WriteLine(sayi);

            Console.WriteLine("");                          // BOŞLUK İÇİN, ÖNEMSEME.

            Array.Resize<int>(ref dizi5, 3);                // Burada eleman sayısı 6 olan dizinimizi 4'e düşürüyoruz.
            Console.WriteLine("**Azaltılmış Hali*");
            Console.WriteLine("");                          // BOŞLUK İÇİN, ÖNEMSEME.

            foreach (var sayi in dizi5)                     // Dizilerde foreach kullanılır.
                Console.WriteLine(sayi);
        }
    }
}
