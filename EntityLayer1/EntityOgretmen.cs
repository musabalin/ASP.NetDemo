using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer1
{
    class EntityOgretmen
    {
        private int ogrtid;
        private string ogrtAd;
        private string ogrtBrans;

        public int Ogrtid { get => ogrtid; set => ogrtid = value; }
        public string OgrtAd { get => ogrtAd; set => ogrtAd = value; }
        public string OgrtBrans { get => ogrtBrans; set => ogrtBrans = value; }
    }
}
