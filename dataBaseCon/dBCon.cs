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
namespace dataBaseCon
{
    public static class dBCon
    {
        static MDbConnection baglanti = new MDbConnection(
            new MDbConnectionStringBuilder()
            {
                #if MySQL
                Server = "localhost", // gerçek durumda server ip'si
                Database = "app",
                UserID = "root",
                Password = "123456",
                #elif MSSQL
                #elif ACCESS
                #endif
            }.ConnectionString);
        public static int oyuncuEkle(string id, string ad,string money, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MDbCommand komut = new MDbCommand("oyuncuEkle", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@id", id);
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@money", money);
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
        public static int oyuncuUpdate(string id, string ad,int money, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MDbCommand komut = new MDbCommand("oyuncuUpdate", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@id", id);
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@money", money);
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
        public static int oyuncuSil(string id, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MDbCommand komut = new MDbCommand("oyuncuSil", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@id", id);
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
        public static int alimIslemEkle(string islemId, string oyuncuId, string urunId, int beforeMoney, int afterMoney, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MDbCommand komut = new MDbCommand("alimIslemEkle", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@islemId", islemId);
                komut.Parameters.AddWithValue("@oyuncuId", oyuncuId);
                komut.Parameters.AddWithValue("@urunId", urunId);
                komut.Parameters.AddWithValue("@beforeMoney", beforeMoney);
                komut.Parameters.AddWithValue("@afterMoney", afterMoney);

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
        public static int alimIslemGuncelle(string islemId, string oyuncuId, string urunId, int beforeMoney, int afterMoney, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MDbCommand komut = new MDbCommand("alimIslemGuncelle", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@islemId", islemId);
                komut.Parameters.AddWithValue("@oyuncuId", oyuncuId);
                komut.Parameters.AddWithValue("@urunId", urunId);
                komut.Parameters.AddWithValue("@beforeMoney", beforeMoney);
                komut.Parameters.AddWithValue("@afterMoney", afterMoney);
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
        public static int alimIslemSil(string islemId, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MDbCommand komut = new MDbCommand("alimIslemSil", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@islemId", islemId);

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
        public static List<(string oyuncuId, string oyuncuName, string oyuncuMoney)> tumOyuncular(out string error)
        {
            List<(string, string, string)> list = new List<(string, string, string)>();
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MDbCommand komut = new MDbCommand("oyuncular", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                MDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    list.Add((
                        dr[0].ToString(),
                        dr[1].ToString(),
                        dr[2].ToString())
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
        public static List<(string islemId, string oyuncuId, string urunId, int beforeMoney,int afterMoney)> alimIslemBul(string id, out string error)
        {
            List<(string, string, string, int, int)> list = new List<(string, string, string, int, int)>();
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MDbCommand komut = new MDbCommand("alimIslemBul", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@id", id);
                MDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    list.Add((
                        dr[0].ToString(),
                        dr[2].ToString(),
                        dr[3].ToString(),
                        (int)dr[4],
                        (int)dr[5]
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
        public static List<(string oyuncuId, string oyuncuName, int money)> oyuncuBul(string filtre, out string error)
        {
            List<(string, string, int)> list = new List<(string, string, int)>();
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MDbCommand komut = new MDbCommand("oyuncuBul", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("filtre", filtre);
                MDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    list.Add((
                        dr[0].ToString(),
                        dr[1].ToString(),
                        (int)dr[2])
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
        public static List<(string islemId, string oyuncuId, string urunId, int beforeMoney, int afterMoney)> alimislemleri(string filtre, out string error)
        {
            List<(string, string, string, int, int)> list = new List<(string, string, string, int, int)>();
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MDbCommand komut = new MDbCommand("alimIslemleri", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                MDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    list.Add((
                        dr[0].ToString(),
                        dr[1].ToString(),
                        dr[2].ToString(),
                        (int)dr[3],
                        (int)dr[4]
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
        public static List<(string urunId, int urunFiyat, string urunName)> urunler(string filtre, out string error)
        {
            List<(string, int, string)> list = new List<(string, int, string)>();
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MDbCommand komut = new MDbCommand("urunler", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                MDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    list.Add((
                        dr[0].ToString(),
                        (int)dr[1],
                        dr[2].ToString()
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
        public static int urunEkle(string urunId,int urunFiyat, string urunName, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MDbCommand komut = new MDbCommand("urunler", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@urunId", urunId);
                komut.Parameters.AddWithValue("@urunFiyat", urunFiyat);
                komut.Parameters.AddWithValue("@urunName", urunName);
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
        public static int urunGuncelle(string urunId, int urunFiyat, string urunName, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MDbCommand komut = new MDbCommand("UrunGuncelle", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@urunId", urunId);
                komut.Parameters.AddWithValue("@urunFiyat", urunFiyat);
                komut.Parameters.AddWithValue("@urunName", urunName);
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
        public static int urunSil(string urunId, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MDbCommand komut = new MDbCommand("UrunGuncelle", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@urunId", urunId);
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
        public static List<(string urunId,string urunName)> urunBul(string filtre, out string error)
        {
            List<(string, string)> list = new List<(string, string)>();
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MDbCommand komut = new MDbCommand("urunler", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                MDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    list.Add((
                        dr[0].ToString(),
                        dr[2].ToString()
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
        public static List<(string islemId, string oyuncuId, int miktar ,int beforeMoney, int afterMoney)> moneyIslemleri(out string error)
        {
            List<(string, string,int ,int ,int)> list = new List<(string, string,int ,int ,int)>();
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MDbCommand komut = new MDbCommand("moneyIslemleri", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                MDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    list.Add((
                        dr[0].ToString(),
                        dr[2].ToString(),
                        (int)dr[3],
                        (int)dr[4],
                        (int)dr[5]
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
        public static int moneyIslemSil(string id, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MDbCommand komut = new MDbCommand("moneyIslemSil", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@id", id);
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
        public static int MoneyislemGuncelle(string islemId, string oyuncuId, int miktar,int beforeMoney,int afterMoney, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MDbCommand komut = new MDbCommand("UrunGuncelle", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@islemId", islemId);
                komut.Parameters.AddWithValue("@oyuncuId", oyuncuId);
                komut.Parameters.AddWithValue("@miktar", miktar);
                komut.Parameters.AddWithValue("@beforeMoney", beforeMoney);
                komut.Parameters.AddWithValue("@afterMoney", afterMoney);
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
        public static List<(string islemId, string oyuncuId, int miktar, int beforeMoney, int afterMoney)> moneyIslemBul(string filtre, out string error)
        {
            List<(string, string, int, int, int)> list = new List<(string, string, int, int, int)>();
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MDbCommand komut = new MDbCommand("moneyIslemBul", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                MDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    list.Add((
                        dr[0].ToString(),
                        dr[2].ToString(),
                        (int)dr[3],
                        (int)dr[4],
                        (int)dr[5]
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
        public static int moneyislemEkle(string islemId, string oyuncuId, int miktar, int beforeMoney, int afterMoney, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MDbCommand komut = new MDbCommand("moneyislemEkle", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@islemId", islemId);
                komut.Parameters.AddWithValue("@oyuncuId", oyuncuId);
                komut.Parameters.AddWithValue("@miktar", miktar);
                komut.Parameters.AddWithValue("@beforeMoney", beforeMoney);
                komut.Parameters.AddWithValue("@afterMoney", afterMoney);
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
    }   
}