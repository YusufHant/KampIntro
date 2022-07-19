using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yusuf Hant
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Yusuf";
            musteri1.Soyadi = "Hant";
            musteri1.TcNo = "12345678910";


            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri =  bunlar birbirine benziyorlar diye birbirleri yerine kullanılamazlar.
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = MusteriManager(MusteriManager);
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
