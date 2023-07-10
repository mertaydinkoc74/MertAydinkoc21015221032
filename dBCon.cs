#define MySQL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Xml;

#if (MSSQL)

#elif (MySQL)
using MDbConnection = MySql.Data.MySqlClient.MySqlConnection;
using MDbConnectionStringBuilder = MySql.Data.MySqlClient.MySqlConnectionStringBuilder;
using MDbCommand = MySql.Data.MySqlClient.MySqlCommand;
using MDbDataReader = MySql.Data.MySqlClient.MySqlDataReader;
using MDbDataAdapter = MySql.Data.MySqlClient.MySqlDataAdapter;
#elif(ACCESS)

#endif

namespace VeresiyeDL
{
    public static class DL
    {
        static MDbConnection baglanti = new MDbConnection(
            new MDbConnectionStringBuilder()
            {
#if MySQL
                Server = "localhost", // gerçek durumda server ip'si
                Database = "veresiye3",
                UserID = "root",
                Password = "wfnxy123",
#elif MSSQL
                
#elif ACCESS
#endif
            }.ConnectionString);
        public static int KisiEkle(string kid, string ad, string soyad, string tel, string mail, string adres, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MDbCommand komut = new MDbCommand("KisiEkle", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@kid", kid);
                komut.Parameters.AddWithValue("@adi", ad);
                komut.Parameters.AddWithValue("@soy", soyad);
                komut.Parameters.AddWithValue("@tel", tel);
                komut.Parameters.AddWithValue("@mail", mail);
                komut.Parameters.AddWithValue("@adr", adres);

                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int KisiDuzenle(string kid, string ad, string soyad, string tel, string mail, string adres, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MDbCommand komut = new MDbCommand("KisiDuzenle", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@kid", kid);
                komut.Parameters.AddWithValue("@adi", ad);
                komut.Parameters.AddWithValue("@soy", soyad);
                komut.Parameters.AddWithValue("@tel", tel);
                komut.Parameters.AddWithValue("@mail", mail);
                komut.Parameters.AddWithValue("@adr", adres);

                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int KisiSil(string kid, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MDbCommand komut = new MDbCommand("KisiSil", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@kid", kid);
                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int GirdiEkle(string gid, string kid, float miktar, DateTime tarih, string aciklama, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MDbCommand komut = new MDbCommand("GirdiEkle", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@gid", gid);
                komut.Parameters.AddWithValue("@kid", kid);
                komut.Parameters.AddWithValue("@mik", miktar);
                komut.Parameters.AddWithValue("@tar", tarih);
                komut.Parameters.AddWithValue("@ack", aciklama);

                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int GirdiDuzenle(string gid, float miktar, DateTime tarih, string aciklama, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MDbCommand komut = new MDbCommand("GirdiDuzenle", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@gid", gid);
                komut.Parameters.AddWithValue("@mik", miktar);
                komut.Parameters.AddWithValue("@tar", tarih);
                komut.Parameters.AddWithValue("@ack", aciklama);

                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int GirdiSil(string gid, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MDbCommand komut = new MDbCommand("GirdiSil", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@gid", gid);

                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }




        public static List<(string kid, string ad, string soy, string tel, string mail, string adres)> TumKisiler(out string error)
        {
            List<(string, string, string, string, string, string)> list = new List<(string, string, string, string, string, string)>();
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MDbCommand komut = new MDbCommand("TumKisiler", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                MDbDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    list.Add((
                        dr[0].ToString(),
                        dr[1].ToString(),
                        dr[2].ToString(),
                       dr[3].ToString(),
                       dr[4].ToString(),
                       dr[5].ToString())
                    );
                }
                error = "";
                return list;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static List<(string gid, float miktar, DateTime tarih, string aciklama)> KisiGirdileri(string kid, out string error)
        {
            List<(string, float, DateTime, string)> list = new List<(string, float, DateTime, string)>();
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MDbCommand komut = new MDbCommand("KisiGirdileri", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@kid", kid);
                MDbDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    list.Add((
                        dr[0].ToString(),
                        (float)dr[2],
                       (DateTime)dr[3],
                       dr[4].ToString()
                    ));
                }
                error = "";
                return list;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static List<(string kid, string ad, string soy, string tel, string mail, string adres)> KisiBul(string filtre, out string error)
        {
            List<(string, string, string, string, string, string)> list = new List<(string, string, string, string, string, string)>();
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MDbCommand komut = new MDbCommand("KisiBul", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("filtre", filtre);
                MDbDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    list.Add((
                        dr[0].ToString(),
                        dr[1].ToString(),
                        dr[2].ToString(),
                       dr[3].ToString(),
                       dr[4].ToString(),
                       dr[5].ToString())
                    );
                }
                error = "";
                return list;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }
    }
}
