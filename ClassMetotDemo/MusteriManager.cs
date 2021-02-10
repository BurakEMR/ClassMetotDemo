using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void musteriAdd(Musteri musteri)
        {
            Console.WriteLine( "Id Numarası Giriniz:" + musteri.MusteriId + " " + musteri.MusteriName + " " + musteri.MusteriSurname);
            Console.WriteLine("Müşteri başarıyla eklendi");
        }

        public void musteriDelete(Musteri musteri)
        {
            Console.WriteLine("Id Numarası Giriniz:"+ musteri.MusteriId + " " + musteri.MusteriName +" " + musteri.MusteriSurname );
            Console.WriteLine("Müşteri başarıyla silindi"); 
        }

        public void musteriList(Musteri [] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
         
                Console.WriteLine("Id Numarası Giriniz:" + musteri.MusteriId + " " + musteri.MusteriName + " " + musteri.MusteriSurname);
                Console.WriteLine("Müşteriler başarıyla listelendi");
            }
        }

    }
}
