using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer1;
using DataAccesLayer;


namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> BLLDersListele()
        {
            return DALDers.DersListesi();
        }
        public static int BLLTalepEkle(EntityBasvurular p)
        {
            if(p.BasDersID!=null && p.BasOgrID!=null)
            {
                return DALDers.TalepEkle(p);
            }
            return -1;

        }
    }
}
