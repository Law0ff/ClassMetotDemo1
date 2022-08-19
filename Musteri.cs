using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Musteri 
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int MusteriNo { get; set; }

        public Musteri(string ad,string soyad , int id,int no)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Id = id;
            this.MusteriNo = no;

        }

        
    }
}
