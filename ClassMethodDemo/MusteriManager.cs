using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            
            Console.WriteLine("İsim: "+musteri.Name + "\nSoyisim: "+musteri.Lastname + "\nMusteri Id: "+musteri.Id + "\nMusteri TcNo:"+musteri.TcNo);
            Console.WriteLine("Yeni kisi eklediniz!!!\n");


        }
        public void MusteriListele(Musteri[] musteriler) 
        {
            
            Console.WriteLine("Musteri Listesi : ");
            
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Name+" "+musteri.Lastname);
            }

        }
        public void MusteriSil(Musteri musteri)
        {
            
            Console.WriteLine(musteri.Name+" "+musteri.Lastname+" "+ "Kisini sildiniz!!!" );

        }




    }
}
