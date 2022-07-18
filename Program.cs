using System;
namespace console_programlama
{ 
    class Program
    {
        static void Main(string[] args)//
        {
            Console.WriteLine("bir sayi girin");
            int sayi=int.Parse(Console.ReadLine());
            int sayac=1;
            int toplam=0;
            while(sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);
            //1 den başlayarak konsoldan girilen sayı kadar ortalama hesaplayan console yazdırın
            //a dan z ye kadar tüm harfleri yazdır
            char karakter='a';
            while(karakter<='z')
            {
                Console.WriteLine(karakter);
                karakter++;
            }

            string[] cars={"ford","V","BMW"};
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }


        }
    }
}
