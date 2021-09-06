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
    public partial class OgrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Gelen Değişkeni yakalama
            int gelen = Convert.ToInt32(Request.QueryString["OgrID"]);
            Response.Write(gelen);
            EntityOgrenci ent = new EntityOgrenci();
            ent.Id1 = gelen;
            BLLOgrenci.BLLSil(ent.Id1);
            Response.Redirect("Ogrenciler.aspx");
        }
    }
}