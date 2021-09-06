using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccesLayer;
using EntityLayer1;
using BusinessLogicLayer;

namespace YazOkulu
{
    public partial class Ogrenciler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad1 = TxtAd.Text;
            ent.Soyad1 = TxtSoyad.Text;
            ent.Numara1 = TxtNo.Text;
            ent.Sifre1 = TxtSifre.Text;
            ent.Fotograf1 = TxtFoto.Text;
            BusinessLogicLayer.BLLOgrenci.OgrenciEkleBLL(ent);
        }
    }
}