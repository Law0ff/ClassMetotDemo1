using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassMetotDemo
{
    
    class MusteriManager
    {

         List<Musteri> Uyeler = new List<Musteri>();
        
        public bool idVarMı;
         
        public void MusteriListele()
        {
            
            Console.WriteLine("Müşteri Listesi");
            
            if (Uyeler.Count == 0)
            {
                Console.WriteLine("Liste boş müşteri kaydedin");
            }
            else
            {
                DiziGoster(Uyeler);
            }
        }
        public void MusteriEkleme(string Ad , string soyad, int no,int id)
        {

            Uyeler.Add(new Musteri(Ad, soyad, id, no));
                       
        }
        public void MusteriSilme()
        {
            Console.WriteLine("Silmek istediğiniz müşterilenin id'sini giriniz");
            int id = int.Parse(Console.ReadLine());
            Musteribul(id);

            Musteri o = this.Uyeler.Where(a => a.Id == id).FirstOrDefault();
            if (o != null)
            {
                Uyeler.Remove(o);
            }
           
        }

        public void MusteriVeriAlma()
        {
            Console.Write("Müşteri adı giriniz: ");
            string ad = Console.ReadLine();
            Console.Write("Müşteri soyadı giriz: ");
            string soyad = Console.ReadLine();
            Console.Write("Müşteri numarası giriniz: ");
            int no = int.Parse(Console.ReadLine());
            Console.Write("Müşteri Id'si giriniz: ");
            int id = int.Parse(Console.ReadLine());           
            MusteriEkleme(ad, soyad, no, id);
            Console.WriteLine(ad + " isimli müşteri sisteme eklendi.");
        }

        public void DiziGoster(List<Musteri> list)
        {
            Console.WriteLine("Müşteri Adı Soyadı" + " | "+ "Müşteri No");
            Console.WriteLine("------------------------------------------");
            foreach (Musteri item in list)
            {
                
                Console.WriteLine("" +item.Ad + " " + item.Soyad.PadRight(20) +  item.MusteriNo);
                
            }
        }

        public void Musteribul(int id)
        {

            Musteri uye = null;
            foreach (Musteri item in Uyeler)
            {
                if (id == item.Id)
                {
                    uye = item;
                }

            }
            if (uye != null)
            {
                Console.WriteLine("Müşterinin Adı Soyadı:" + uye.Ad + " " + uye.Soyad);
                Console.WriteLine("Silindi");
                idVarMı = true;


            }
            else if (uye == null)
            {
                Console.WriteLine("Bu numarada bir ögrenci yok.Tekrar deneyin.");

                idVarMı = false;

            }



        }


    }

            
}
