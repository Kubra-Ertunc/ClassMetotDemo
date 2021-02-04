using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Name = "Kubra";
            musteri1.Lastname = "ERTUNC";
            musteri1.Id = 1;
            musteri1.TcNo = "12345678912";

            Musteri musteri2 = new Musteri();

            musteri2.Name = "Aylin";
            musteri2.Lastname = "Ozturk";
            musteri2.Id = 2;
            musteri2.TcNo = "12345678900";

            Musteri musteri3 = new Musteri();

            musteri3.Name = "Ali";
            musteri3.Lastname = "Can";
            musteri3.Id = 3;
            musteri3.TcNo = "12345678999";

            Console.WriteLine("-------------------Musteri Ekleme---------------------");
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);


            Console.WriteLine("-------------------Musteri Listeleme---------------------");
            Musteri[] musteris = new Musteri[] {musteri1,musteri2,musteri3 };
            musteriManager.MusteriListele(musteris);


            Console.WriteLine("---------------------Musteri Silme-----------------------");
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriSil(musteri3);


        }
    }
}
