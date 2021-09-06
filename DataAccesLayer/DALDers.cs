using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer1;

namespace DataAccesLayer
{
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> deger = new List<EntityDers>();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Ders", Baglanti.bgl);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.Id = Convert.ToInt32(dr["DersID"].ToString());
                ent.DersAd = dr["DersAd"].ToString();
                ent.Min = Convert.ToInt32(dr["DersMinKontenjan"].ToString());
                ent.Max = Convert.ToInt32(dr["DersMaksKontenjan"].ToString());
                deger.Add(ent);
            }
            dr.Close();
            return deger;

        }
        public static int TalepEkle(EntityBasvurular parametre)
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Basvurular (OgrenciID,DersID) values (@p1,@p2)", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", parametre.BasOgrID);
            komut.Parameters.AddWithValue("@p2", parametre.BasDersID);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();

        }
    }
}
