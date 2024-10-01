namespace SanalMarket1
{
    internal class Program
    {
        static void Main(string[] args)  
       
        //Main metodu otomatik olarak çağrılır ve içindeki Urunler() metodu çalıştırılır.
        {
            
            Urunler();
        }

        internal static void Urunler()
        {
            string[] giyimUrunler = { "Elbise", "Pantalon", "Kazak" };
            double[] giyimFiyatlar = { 300, 500, 350 };

            string[] gidaUrunler = { "Yağ", "Ekmek", "Un" };
            double[] gidaFiyatlar = { 95, 10, 65 };

            string[] bijuteriUrunler = { "Saat", "Kolye", "Bileklik" };
            double[] bijuteriFiyatlar = { 500, 250, 200 };

            while (true)
            {
                AnaMenuGoster();
                int secim = int.Parse(Console.ReadLine());

                if (secim == 1)
                {
                    UrunGoster(bijuteriUrunler, bijuteriFiyatlar, "Bijuteri");
                }
                else if (secim == 2)
                {
                    UrunGoster(gidaUrunler, gidaFiyatlar, "Gıda");
                }
                else if (secim == 3)
                {
                    UrunGoster(giyimUrunler, giyimFiyatlar, "Giyim");
                }
                else if (secim == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı seçim! Lütfen tekrar deneyin.");
                }
            }
        }

        internal static void AnaMenuGoster()
        {
            Console.Clear();
            Console.WriteLine("**** Sanal Market ****");
            Console.WriteLine("1- Bijuteri Ürünlerini Göster");
            Console.WriteLine("2- Gıda Ürünlerini Göster");
            Console.WriteLine("3- Giyim Ürünlerini Göster");
            Console.WriteLine("4- Çıkış");
            Console.Write("Seçiminizi yapınız: ");
        }

        internal static void UrunGoster(string[] urunler, double[] fiyatlar, string kategori)
        {
            Console.Clear();
            Console.WriteLine($"**** {kategori} Ürünleri ****");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {urunler[i]}: {fiyatlar[i]} TL");
            }

            
        }

        internal static void UrunSat(string[] urunler, double[] fiyatlar, string kategori)
            ////////////////////(string[] urunler, double[] fiyatlar, string kategori)
        //Metodun çalışması için gereken verilerin dışarıdan alınmasını sağlıyor. Bu parametleri yazmazsak hangi verilerin kullanacağını bilemeyiz. 
        {
            Console.Write("Satın almak istediğiniz ürün numarasını girin: ");
            int urunNo = int.Parse(Console.ReadLine()) - 1;

            if (urunNo >= 0 && urunNo < urunler.Length)
            {
                double urunFiyati = fiyatlar[urunNo];
                double kdv = urunFiyati * 0.05;
                double toplamFiyat = urunFiyati + kdv;

                Console.WriteLine($"Toplam fiyat (KDV dahil): {toplamFiyat} TL");
                Console.Write("Ödeme için para girin: ");
                double odeme = double.Parse(Console.ReadLine());

                if (odeme >= toplamFiyat)
                {
                    double paraUstu = odeme - toplamFiyat;
                    Console.WriteLine($"{urunler[urunNo]} başarıyla satın alındı! Para üstü: {paraUstu} TL");
                }
                else
                {
                    Console.WriteLine("Yetersiz ödeme! İşlem iptal edildi.");
                }
            }
            else
            {
                Console.WriteLine("Hatalı ürün numarası!");
            }

            
        }

        internal static void CıkısIslemleri()
        {
            Console.WriteLine("Başka bir işlem yapmak için 1'e basınız.");
            string cevap = Console.ReadLine().ToUpper();
            if (cevap == "1")
            {
                Console.WriteLine("Ana Menüye Yönlendiriliyorsunuz..");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Çıkış yapılıyor...");
                Environment.Exit(0);
            }
        }
    }
}

