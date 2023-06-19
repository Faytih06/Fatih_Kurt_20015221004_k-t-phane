using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatih_Kurt_20015221004_kütüphane.DL
{
   public static class DataLayer
    {
       static MySqlConnection connection = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            {
                Server = "127.0.0.1",
                Database = "kutuphane",
                UserID = "root",
                Password = "Fth2206*",
            }.ConnectionString
        );

        public static int ÜyeEkle(Uyeler m)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlCommand komut = new MySqlCommand("kütüphane_UyeEkle", connection);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.ID);
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soy", m.Soyad);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@mail", m.Mail);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
           
            
        }

        internal static int KitapEkle(Kitap kitap)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlCommand komut = new MySqlCommand("kütüphane_KitapEkle", connection);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", kitap.ID);
                komut.Parameters.AddWithValue("@ad", kitap.Ad);
                komut.Parameters.AddWithValue("@yazar", kitap.Yazar);
                komut.Parameters.AddWithValue("@yayın", kitap.Yayın);
                komut.Parameters.AddWithValue("@dil", kitap.Dil);
                komut.Parameters.AddWithValue("@tür", kitap.Tür);
                komut.Parameters.AddWithValue("@sayfa", kitap.Sayfa);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        

        internal static DataSet ÜyeGetir(string filtre)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("kütüphane_ÜyeHepsi", connection);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;                
                }
                else
                {
                    komut = new MySqlCommand("kütüphane_ÜyeBul", connection);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }

                  DataSet dataSet= new DataSet();
                  MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                  adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        internal static int ÜyeGüncelle(Uyeler m)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlCommand komut = new MySqlCommand("kütüphane_ÜyeGüncelle", connection);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.ID);
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soy", m.Soyad);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@mail", m.Mail);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        internal static int ÜyeSil(string id)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlCommand komut = new MySqlCommand("kütüphane_ÜyeSil", connection);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);
              
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        internal static DataSet KitapGetir(string filtre)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("kütüphane_KitapHepsi", connection);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("kütüphane_KitapBul", connection);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        internal static int KitapGüncelle(Kitap kitap)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlCommand komut = new MySqlCommand("kütüphane_KitapGuncelle", connection);
                komut.Parameters.AddWithValue("@id", kitap.ID);
                komut.Parameters.AddWithValue("@ad", kitap.Ad);
                komut.Parameters.AddWithValue("@yazar", kitap.Yazar);
                komut.Parameters.AddWithValue("@yayın", kitap.Yayın);
                komut.Parameters.AddWithValue("@dil", kitap.Dil);
                komut.Parameters.AddWithValue("@tür", kitap.Tür);
                komut.Parameters.AddWithValue("@sayfa", kitap.Sayfa);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }
    }
}
