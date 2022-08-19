using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Uygulama();
            
        }


        public static void Uygulama()
        {
            MusteriManager musteri = new MusteriManager();  
            

            Menu();
            while (true)
            {
               
                string sonuc = Console.ReadLine().ToUpper();
                switch (sonuc)
                {   
                    case "1":
                    case "listele":
                        musteri.MusteriListele();
                        break;
                    case "2":
                    case "ekle":
                        musteri.MusteriVeriAlma();
                        break;
                    case "3":
                    case "sil":
                        musteri.MusteriSilme();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        return;
                }
            }
            




        }

        static void Menu()
        {
            Console.WriteLine("Banka Müşteri Servisi");
            Console.WriteLine("Müşteri listelemek için = '1' - listele ");
            Console.WriteLine("Müşteri Eklemek için = '2'- ekle ");
            Console.WriteLine("Müşteri Silmek için = '3'- sil ");       
            Console.WriteLine("Çıkış için = '0' ");
            
        }
        
        




    }
}
