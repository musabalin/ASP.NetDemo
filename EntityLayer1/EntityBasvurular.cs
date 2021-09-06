using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer1
{
  public  class EntityBasvurular
    {
        private int basvuruID;
        private int basDersID;
        private int basOgrID;

        public int BasvuruID { get => basvuruID; set => basvuruID = value; }
        public int BasDersID { get => basDersID; set => basDersID = value; }
        public int BasOgrID { get => basOgrID; set => basOgrID = value; }
    }
}
