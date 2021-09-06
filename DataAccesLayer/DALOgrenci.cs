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
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into Tbl_Ogrenci (OgrAd,OgrSoyad,OgrNumara,OgrFoto,OgrSifre) values(@p1,@p2,@p3,@p4,@p5) ", Baglanti.bgl);

            komut1.Parameters.AddWithValue("@p1", parametre.Ad1);
            komut1.Parameters.AddWithValue("@p2", parametre.Soyad1);
            komut1.Parameters.AddWithValue("@p3", parametre.Numara1);
            komut1.Parameters.AddWithValue("@p4", parametre.Fotograf1);
            komut1.Parameters.AddWithValue("@p5", parametre.Sifre1);
            return komut1.ExecuteNonQuery();

        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("Select * From Tbl_Ogrenci", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();

            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Id1 = Convert.ToInt32(dr["OgrID"]);//SQLdeki isimler yazılır.
                ent.Ad1 = dr["OgrAd"].ToString();
                ent.Soyad1 = dr["OgrSoyad"].ToString();
                ent.Numara1 = dr["OgrNumara"].ToString();
                ent.Fotograf1 = dr["OgrFoto"].ToString();
                ent.Sifre1 = dr["OgrSifre"].ToString();
                ent.Bakiye1 = Convert.ToDouble(dr["OgrBakiye"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;

        }

        public static bool OgrenciSil(int parametre2)
        {
            SqlCommand komut3 = new SqlCommand("Delete From Tbl_Ogrenci where OgrId=@p1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", parametre2);
            return komut3.ExecuteNonQuery() > 0;

        }

        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komutd = new SqlCommand("Select * From Tbl_Ogrenci where OgrID=@p1", Baglanti.bgl);
            komutd.Parameters.AddWithValue("@p1", id);
            if (komutd.Connection.State != ConnectionState.Open)
            {
                komutd.Connection.Open();

            }
            SqlDataReader dr = komutd.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ad1 = dr["OgrAd"].ToString();
                ent.Soyad1 = dr["OgrSoyad"].ToString();
                ent.Numara1 = dr["OgrNumara"].ToString();
                ent.Fotograf1 = dr["OgrFoto"].ToString();
                ent.Sifre1 = dr["OgrSifre"].ToString();
                ent.Bakiye1 = Convert.ToDouble(dr["OgrBakiye"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;

        }

        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut5 = new SqlCommand("Update Tbl_Ogrenci set OgrAd=@p1, OgrSoyad=@p2, OgrNumara=@p3, OgrSifre=@p4, OgrFoto=@p5 where OgrID=@p6", Baglanti.bgl);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@p1", deger.Ad1);
            komut5.Parameters.AddWithValue("@p2", deger.Soyad1);
            komut5.Parameters.AddWithValue("@p3", deger.Numara1);
            komut5.Parameters.AddWithValue("@p4", deger.Sifre1);
            komut5.Parameters.AddWithValue("@p5", deger.Fotograf1);
            komut5.Parameters.AddWithValue("@p6", deger.Id1);
            return komut5.ExecuteNonQuery() > 0;


        }
        

    }
}
