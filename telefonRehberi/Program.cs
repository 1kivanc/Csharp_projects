using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telefonRehberi
{
    internal class Program
    {
        static Dictionary<String, String> rehber = new Dictionary<String, String>
        {
            {"Ali","0587465987"},
            {"Mehmet","05632845627" },
            {"Burak","05236547523" },
            {"Ayşe","05876325475" },
            {"Fatma","05236458455" }

        };
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
                Console.WriteLine("1. Telefon Numarası Kaydet ");
                Console.WriteLine("2. Telefon Numarası Sil ");
                Console.WriteLine("3. Telefon numarası Güncelle ");
                Console.WriteLine("4. Rehber Listeleme (A-Z)");
                Console.WriteLine("5. Rehber Listeleme (Z-A)");
                Console.WriteLine("6. Rehberde Arama");
                Console.WriteLine("7. Çıkış");

                int secim;
                if(int.TryParse(Console.ReadLine(), out secim))
                {
                    switch (secim)
                    {
                        case 1:
                            TelefonNumarasiKaydet();
                            break;
                        case 2:
                            TelefonNumarasiSil();
                            break;
                        case 3:
                            TelefonNumarasiGuncelle();
                            break;
                        case 4:
                            RehberiListele(true);
                            break;
                        case 5:
                            RehberiListele(false);
                            break;
                        case 6:
                            RehberdeAra();
                            break;
                        case 7:
                            Console.WriteLine("Çıkış yapılıyor....");
                            return;
                        default:
                            Console.WriteLine("Geçersiz seçim. lütfen geçerli bir işlem seciniz");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim. lütfen geçerli bir işlem seciniz");
                }

                Console.WriteLine();
            }
        }

        static void TelefonNumarasiKaydet()
        {
            Console.Write("Ad: ");
            string ad = Console.ReadLine();
            Console.Write("Telefon Numarası: ");
            string telefon = Console.ReadLine();

            rehber[ad] = telefon;
            Console.WriteLine("Telefon Numarası kaydedildi");
        }

        static void TelefonNumarasiSil()
        {
            Console.WriteLine("Silmek istediğiniz kişinin adını girin: ");
            string ad = Console.ReadLine();
            if (rehber.ContainsKey(ad))
            {
                rehber.Remove(ad);
                Console.WriteLine("Telefon numarası silindi");
            }
            else
            {
                Console.WriteLine("Kişi rehberde bulunamadı");
            }

        }

        static void TelefonNumarasiGuncelle()
        {
            Console.WriteLine("Telefon numarasını Güncellemek istediğin kişinin adını gir: ");
            string ad = Console.ReadLine();
            if (rehber.ContainsKey(ad))
            {
                Console.WriteLine("Yeni Telefon numarası giriniz: ");
                string yeniTelefon = Console.ReadLine();

                rehber[ad] = yeniTelefon;
                Console.WriteLine("Telefon numarası güncellendi");

            }
            else
            {
                Console.WriteLine("Kişi rehberde Bulunamadı");
            }

        }

        static void RehberiListele(bool az)
        {
            var siraliRehber = az
                ? rehber.OrderBy(kvp=>kvp.Key)
                : rehber.OrderByDescending(kvp=>kvp.Value);
            
            foreach(var kvp in siraliRehber)
            {
                Console.WriteLine($"Ad: {kvp.Key}, Telefon: {kvp.Value}");
            }
        }

        static void RehberdeAra()
        {
            Console.WriteLine("Aramak istediğiniz Kişinin adını girin: ");
            string ad = Console.ReadLine();

            if (rehber.ContainsKey(ad))
            {
                Console.WriteLine($"Ad: {ad}, Telefon: {rehber[ad]}");
            }
            else
            {
                Console.WriteLine("Kişi rehberde bulunamadı");
            }

        }

    }
}
