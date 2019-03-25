using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.raporlar
{
   public class tahsilatBilgi
    {
        private int ogrenciId = 0;

        public int OgrenciId
        {
            get { return ogrenciId; }
            set { ogrenciId = value; }
        }


        private string ogrenciAd = "deneme";
        public string OgrenciAd
        {
            get { return ogrenciAd; }
            set { ogrenciAd = value; }
        }


        private string ogrenciSoyAd = "deneme s Ad";
        public string OgrenciSoyAd
        {
            get { return ogrenciSoyAd; }
            set { ogrenciSoyAd = value; }
        }

        private string servisPlaka = "33ABC34";
        public string ServisPlaka
        {
            get { return servisPlaka; }
            set { servisPlaka = value;}
        }

        private string miktar = "0";
        public string Miktar
        {
            get { return miktar; }
            set { miktar = value; }
        }

        private string tarih = " ";
        public string Tarih
        {
            get { return  tarih; }
            set { tarih = value; }
        }

        private string kalanBorc = "";
        public string KalanBorc
        {
            get { return kalanBorc; }
            set { kalanBorc = value; }
        }





    }
}
