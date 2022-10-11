using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace RememberMyPassword
{
    class Class1
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\sifredb.mdb;Persist Security Info=True;");

        public string sifrele(string sifre, string hash)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(sifre);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }
        public  string coz(string SifrelenmisDeger, string hash)
        {
            try
            {
                byte[] data = Convert.FromBase64String(SifrelenmisDeger);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {

                        ICryptoTransform transform = tripDes.CreateDecryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        return UTF8Encoding.UTF8.GetString(results);


                    }
                }
            }
            catch
            {
                return SifrelenmisDeger;
            }
        }



        public DataTable listeleme(string komut)
        {
            connection.Close();
            connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(komut, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            connection.Close();
        }


        public void ekleme(string komut)
        {
            connection.Close();
            connection.Open();
            OleDbCommand com = new OleDbCommand(komut, connection);
            com.ExecuteNonQuery();
            connection.Close();
        }



        public void sil(string komut)
        {
            connection.Close();
            connection.Open();
            OleDbCommand com = new OleDbCommand(komut, connection);
            com.ExecuteNonQuery();
            connection.Close();
        }

        public void güncel(string komut)
        {
            connection.Close();
            connection.Open();
            OleDbCommand com = new OleDbCommand(komut, connection);
            com.ExecuteNonQuery();
            connection.Close();
        }
    }
}
