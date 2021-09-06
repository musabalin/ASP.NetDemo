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
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
             
                DropDownList1.DataSource = BLLDers.BLLDersListele();
                DropDownList1.DataTextField = "DersAd";//hangi Şekilde tuttuğu
                DropDownList1.DataValueField = "Id";//arkaplanda ne tutacak onu seçtik
                DropDownList1.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //TextBox1.Text = DropDownList1.SelectedValue.ToString();
            EntityBasvurular ent = new EntityBasvurular();
            ent.BasOgrID = int.Parse(TextBox1.Text);
            ent.BasDersID = int.Parse(DropDownList1.SelectedValue.ToString());
            BLLDers.BLLTalepEkle(ent);
        }
    }
}