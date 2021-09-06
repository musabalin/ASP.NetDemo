using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer1;
using DataAccesLayer;
using BusinessLogicLayer;

namespace YazOkulu
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int gelen =Convert.ToInt32( Request.QueryString["OgrID"].ToString());
            TxtId.Text = gelen.ToString();
            TxtId.Enabled = false;
            if (Page.IsPostBack == false)
            {
                List<EntityOgrenci> OgrList = BLLOgrenci.BLLDetay(gelen);
                TxtAd.Text = OgrList[0].Ad1.ToString();
                TxtSoyad.Text = OgrList[0].Soyad1.ToString();
                TxtNo.Text = OgrList[0].Numara1.ToString();
                TxtFoto.Text = OgrList[0].Fotograf1.ToString();
                TxtSifre.Text = OgrList[0].Sifre1.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //entden bir nesne türetilip içindeki değişkenler çağırılıp içlerine güncellemek istediğimiz değişkenleri atadık
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad1 = TxtAd.Text;
            ent.Soyad1 = TxtSoyad.Text;
            ent.Sifre1 = TxtSifre.Text;
            ent.Numara1 = TxtNo.Text;
            ent.Fotograf1 = TxtFoto.Text;
            ent.Id1 =Convert.ToInt32( TxtId.Text);
            BLLOgrenci.BLLGuncelle(ent);
            Response.Redirect("Ogrenciler.aspx");
        }
    }
}