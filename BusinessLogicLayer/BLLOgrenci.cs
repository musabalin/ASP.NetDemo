using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer1;
using DataAccesLayer;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.Ad1 != null && p.Soyad1 != null && p.Fotograf1 != null && p.Numara1 != null && p.Sifre1 != null)
            {
                return DALOgrenci.OgrenciEkle(p);//
            }
            return -1;// işlemi yapma demek
        }

        public static List<EntityOgrenci> BLLListele()
        {
            return DALOgrenci.OgrenciListesi();
        }

        public static bool BLLSil(int p)
        {
            if (p != null)
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false;
        }

        public static List<EntityOgrenci> BLLDetay(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }

        public static bool BLLGuncelle(EntityOgrenci p)
        {
            if (p.Ad1 != null && p.Soyad1 != null && p.Fotograf1 != null && p.Numara1 != null && p.Sifre1 != null && p.Id1>0)
            {
                return DALOgrenci.OgrenciGuncelle(p);//
            }
            return false;// işlemi yapma demek
        }
    }
}
