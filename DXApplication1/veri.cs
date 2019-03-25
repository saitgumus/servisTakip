using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DXApplication1
{
    public class veri
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=OSP; Integrated Security=true;");


         DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();

       
        public DataTable tabloGetir(string tabloAd)
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            adapter.SelectCommand = new SqlCommand("select * from " + tabloAd, baglanti);
            adapter.Fill(dt);
            baglanti.Close();

            return dt;
        }

     public void ogrenciGuncelle(DataTable dt)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(dt);
        }


        public void ogeSil(string tablo, string id)
        {
            SqlCommand sil = new SqlCommand();
            sil.CommandText = "delete from " + tablo + " where id= " + id;
            sil.Connection = baglanti;
            baglanti.Open();
            sil.ExecuteNonQuery();
            baglanti.Close();
        }




        //son tahsilat yapılan öğrencinin view'ini hazırlar
        //tahsilat yap butonunun click eventinde çalışır
        public raporlar.tahsilatBilgi viewMakbuz(string id, string miktar, string tarih)
        {
        //    SqlCommand cmd = new SqlCommand();

        //cmd.CommandText = "alter view makbuz as "+
        //       " select o.ad, o.soyad, t.taksit 'taksit_sırası', "+
        //      "  t.odenen_miktar , t.odenen_tarih "+
        //       " from tahsilat t join ogrenciler o on o.id = t.ogrenci_id "+
        //       $" where o.id = {id} ";
        //    cmd.Connection = baglanti;
        //    baglanti.Open();
        //    cmd.ExecuteNonQuery();
        //    baglanti.Close();

                raporlar.tahsilatBilgi bilgi = new raporlar.tahsilatBilgi();

            baglanti.Open();

            SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandText = "select  o.ad, o.soyad,"+
                               " sum(t.borc_miktar) 'kalan' "+
                               " from tahsilat t"+
                              "  inner join ogrenciler o on t.ogrenci_id = o.id"+
                              $"  where t.ogrenci_id = {id} "+
                              "  group by o.ad,o.soyad ";
                cmd2.Connection = baglanti;
                SqlDataReader rd = cmd2.ExecuteReader();
            rd.Read();
                bilgi.OgrenciId = Convert.ToInt16(id);
                bilgi.OgrenciAd = rd["ad"].ToString();
                bilgi.OgrenciSoyAd = rd["soyad"].ToString();
                bilgi.Tarih = tarih;
                bilgi.Miktar = miktar;
                bilgi.KalanBorc = rd["kalan"].ToString();


            rd.Close();
            baglanti.Close();

            return bilgi;
        }

        public void insert(string tablo,string deger)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "insert into " + tablo + " values " + deger;
            command.Connection = baglanti;

            baglanti.Open();
            command.ExecuteNonQuery();

            baglanti.Close();
        }



      




        //proceduress
        public void ogrenciEkleProcedure(Dictionary<string,string> keyValues)
        {

           
            SqlCommand sqlCommand = new SqlCommand("ogrenciEkle", baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            foreach(KeyValuePair<string,string> item in keyValues)
            {
                    sqlCommand.Parameters.Add(item.Key, SqlDbType.VarChar);
                    sqlCommand.Parameters[item.Key].Value = item.Value;

            }

            baglanti.Open();
            sqlCommand.ExecuteNonQuery();
            baglanti.Close();


        }

        public void aracEkleProcedure(Dictionary<string,string> keyValues)
        {
            SqlCommand sqlCommand = new SqlCommand("aracEkle", baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            foreach (KeyValuePair<string, string> item in keyValues)
            {
                sqlCommand.Parameters.Add(item.Key, SqlDbType.VarChar);
                sqlCommand.Parameters[item.Key].Value = item.Value;

            }

            baglanti.Open();
            sqlCommand.ExecuteNonQuery();
            baglanti.Close();



        }

        public void okulEkleProcedure(Dictionary<string,string> keyValues)
        {
            SqlCommand sqlCommand = new SqlCommand("okulEkle", baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            foreach (KeyValuePair<string, string> item in keyValues)
            {
                sqlCommand.Parameters.Add(item.Key, SqlDbType.VarChar);
                sqlCommand.Parameters[item.Key].Value = item.Value;

            }

            baglanti.Open();
            sqlCommand.ExecuteNonQuery();
            baglanti.Close();

        }




        //tahsilat prosedürü
        public void tahsilatProcedure(Dictionary<string, string> keyValues)
        {
            raporlar.tahsilatBilgi tahsilatBilgi = new raporlar.tahsilatBilgi();

            SqlCommand sqlCommand = new SqlCommand("tahsilatyap", baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            foreach (KeyValuePair<string, string> item in keyValues)
            {
                sqlCommand.Parameters.Add(item.Key, SqlDbType.VarChar);
                sqlCommand.Parameters[item.Key].Value = item.Value;

            }

            baglanti.Open();
            sqlCommand.ExecuteNonQuery();
            baglanti.Close();

            
        }


    }
}
