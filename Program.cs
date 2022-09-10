using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T--> Generic oldugunu söylüyor. Object türünde, nesne alabilir;

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count:Eleman sayısı
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            //başka bir foreach yazımı
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman Çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //ındexle çıkarma
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(2);
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içersinde arama
            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 Var");
            }

            //eleman ile index 
            Console.WriteLine(renkListesi.BinarySearch("Mavi"));

            //Diziyi listeye çevirme
            string[] hayvan = { "Kedi", "Köpek", "Kuş" };
            List<String> hayvanlar = new List<string>(hayvan);

            //Listeyi Temizleme
            hayvanlar.Clear();

            //Liste içerisnde nesne tutmak 
            List<Kullanıcılar> kullanıcılistesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1=new Kullanıcılar();
            kullanıcı1.Isim="Ayse";
            kullanıcı1.Soyiism="Yılaz";
            kullanıcı1.Yas=26;

            Kullanıcılar kullanıcı2=new Kullanıcılar();
            kullanıcı2.Isim="Ozcan";
            kullanıcı2.Soyiism="Calıskan";
            kullanıcı2.Yas=26;

            kullanıcılistesi.Add(kullanıcı1);
            kullanıcılistesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe=new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar{
                Isim="Deniz",
                Soyiism="Asada",
                Yas=24,
            });

            foreach (var kullanıcı in kullanıcılistesi)
            {
                Console.WriteLine(kullanıcı.Isim);
            }




        }
    }
    public class Kullanıcılar
    {
        private string isim;
        private string soyiism;
        private int yas;

        public string Isim{get=> isim; set=>isim=value;}
        public string Soyiism{get=> soyiism; set=>soyiism=value;}
        public int Yas{get=> yas; set=>yas=value;}

    }
}