using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 123;
            musteri1.MusteriName = "Burak";
            musteri1.MusteriSurname = "Emir";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 456;
            musteri2.MusteriName = "Berkay";
            musteri2.MusteriSurname = "Emir";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 789;
            musteri3.MusteriName = "Enes Salih";
            musteri3.MusteriSurname = "Zabın";

            MusteriManager musteri = new MusteriManager();
            
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            
            musteri.musteriAdd(musteri1);
            musteri.musteriAdd(musteri2);
            musteri.musteriAdd(musteri3);

            musteri.musteriDelete(musteri1);
            musteri.musteriDelete(musteri2);
            musteri.musteriDelete(musteri3);

            Console.WriteLine("MÜŞETERİ LİSTESİ");

            musteri.musteriList(musteriler);




        }
    }
}
