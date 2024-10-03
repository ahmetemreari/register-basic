using System;

namespace KullaniciKayit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz! Lütfen sizden istenilen bilgileri giriniz.");

            // Kullanıcıdan bilgileri al
            Console.Write("T.C. Kimlik Numarası: ");
            string tcKimlikNo = Console.ReadLine();

            Console.Write("Ad: ");
            string ad = Console.ReadLine();

            Console.Write("Soyad: ");
            string soyad = Console.ReadLine();

            Console.Write("Telefon Numarası: ");
            string telefonNo = Console.ReadLine();

            Console.Write("Yaş: ");
            int yas = int.Parse(Console.ReadLine());

            Console.Write("İlk Ürünün Fiyatı: ");
            int ilkUrunFiyati = int.Parse(Console.ReadLine());

            Console.Write("İkinci Ürünün Fiyatı: ");
            int ikinciUrunFiyati = int.Parse(Console.ReadLine());

            // Toplam harcama ve kazanılan puan hesapla
            int toplamHarcama = ilkUrunFiyati + ikinciUrunFiyati;
            int kazanilanPuan = toplamHarcama * 0.20m;

            // Kayıt oluşturma ve bildirim mesajı
            Console.WriteLine($"\n{tcKimlikNo} T.C. Kimlik Numaralı, {ad} {soyad} isimli kişi için kayıt oluşturulmuştur.");
            Console.WriteLine($"{telefonNo} telefon numarasına bildirim mesajı gönderilmiştir.");
            Console.WriteLine($"Toplam harcama: {toplamHarcama} TL");
            Console.WriteLine($"Kazanılan %20 Patika Puanı: {kazanilanPuan} puan");
        }
    }
}
