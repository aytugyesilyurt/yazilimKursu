using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aytuğ YEŞİLYURT
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Aytuğ";
            musteri1.Soyadi = "YEŞİLYURT";
            musteri1.TcNo = "12345678912";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "45678";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            //Gerçek Müsteri - Tüzel Müsteri özellikleri farklı olduğu için ayırmak lazım
            //Ayrıca MusteriType = 1 gibi bir ifade de olmaz çünkü ilerleyen zamanlarda müşterilerin türü değişebilir.
            // SOLID "L" 

        }
    }
}
