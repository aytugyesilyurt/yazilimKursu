using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Urunler urun1 = new Urunler();
        urun1.urunAdi = "Kazak";
        urun1.urunBedeni = "M";
        urun1.urunFiyati = 85;

        Urunler urun2 = new Urunler();
        urun2.urunAdi = "Mont";
        urun2.urunBedeni = "L";
        urun2.urunFiyati = 199;

        Urunler urun3 = new Urunler();
        urun3.urunAdi = "Şort";
        urun3.urunBedeni = "M";
        urun3.urunFiyati = 65;

        Urunler[] urunler = new Urunler[] { urun1, urun2, urun3 };

        foreach (var item in urunler)
        {
            Console.WriteLine("Ürün Adı : " + item.urunAdi + " // Bedeni : " + item.urunBedeni + " // Fiyatı : " + item.urunFiyati);
            
        }
        Console.WriteLine("");
        Console.WriteLine("foreach ile yapılan döngü");
        Console.WriteLine("");


        for (int i = 0; i < urunler.Length; i++)
        {
            Console.WriteLine("Ürün Adı : " + urunler[i].urunAdi + " // Bedeni : " + urunler[i].urunBedeni + " // Fiyatı : " + urunler[i].urunFiyati);
        }

        Console.WriteLine("");
        Console.WriteLine("for ile yapılan döngü");
        Console.WriteLine("");

        int j = 0;

        while (j < urunler.Length)
        {
            Console.WriteLine("Ürün Adı : " + urunler[j].urunAdi + " // Bedeni : " + urunler[j].urunBedeni + " // Fiyatı : " + urunler[j].urunFiyati);
            j++;
        }

        Console.WriteLine("");
        Console.WriteLine("While ile yapılan döngü");
        Console.WriteLine("");

    }
    class Urunler
    {
        public string urunAdi { get; set; }
        public string urunBedeni { get; set; }
        public int urunFiyati { get; set; }
    }

}
