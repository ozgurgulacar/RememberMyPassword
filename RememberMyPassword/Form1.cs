using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.Mail;
using System.Net;

namespace RememberMyPassword
{
    public partial class Form1 : Form
    {

        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\sifredb.mdb;Persist Security Info=True;");

        int[] sayılar = new int[6];
        string emailsifre;
        bool kayıt=false;
        Class1 cls  = new Class1();
        gizli gzl = new gizli();
        string anahtar ="";
        bool unutma=false;
        string unutmus="";



        public Form1()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (txtadı.Text=="" || txtsifre.Text=="")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    
                    baglantı.Close();
                    baglantı.Open();
                    OleDbCommand komut = new OleDbCommand("select * from tblkullanıcı where kullanıcıadı=@ad and sifre=@sifre", baglantı);
                    komut.Parameters.AddWithValue("@ad",txtadı.Text);
                    Class1 cls = new Class1();
                    string decrypt = cls.sifrele(txtsifre.Text, gzl.Crypto);

                    komut.Parameters.AddWithValue("@sifre",decrypt);
                    OleDbDataReader oku = komut.ExecuteReader();
                    if (oku.Read())
                    {
                        mesajgönder();
                        txtadı.ReadOnly = true;
                        txtsifre.ReadOnly = true;
                        label3.Visible = true; btnemail.Visible = true; txtemail.Visible = true;
                        anahtar = oku["anahtar"].ToString(); 
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Bilgi Girdiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    baglantı.Close();
                }
                catch (Exception x)
                {

                    MessageBox.Show(x.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false; btnemail.Visible = false; txtemail.Visible = false;
        }
        private void mesajgönder()
        {
            try
            {
                if (unutma==false)
                {
                    emailsifre = kodumuz();
                }
                else
                {
                    emailsifre = unutmus;
                }
                SmtpClient client = new SmtpClient();
                MailMessage mesaj = new MailMessage();
                client.Port = 587;
                client.Host = "smtp.office365.com";
                mesaj.To.Add(txtadı.Text);
                mesaj.From = new MailAddress(gzl.Email);
                mesaj.Subject = "Your RememberMyPassword Launch Code";
                mesaj.Body = emailsifre;
                client.Credentials = new System.Net.NetworkCredential(gzl.Email, gzl.Password);
                client.EnableSsl = true;
                client.Send(mesaj);
                unutma=false; 
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnemail_Click(object sender, EventArgs e)
        {
            if (kayıt==true)
            {
                if (txtemail.Text == emailsifre)
                {
                    try
                    {
                        
                        string encrypt = cls.sifrele(txtsifre.Text, gzl.Crypto);
                        string komut = "insert into tblkullanıcı(kullanıcıadı,sifre) values('" + txtadı.Text + "' , '" + encrypt + "')";
                        cls.ekleme(komut);
                        txtadı.ReadOnly = false;
                        txtsifre.ReadOnly = false;
                        txtadı.Text = "";
                        txtemail.Text = "";
                        txtsifre.Text = "";
                        label3.Visible = false; btnemail.Visible = false; txtemail.Visible = false;
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Kod Hatalı", "Doğrulanamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                if (txtemail.Text == emailsifre)
                {
                    MessageBox.Show("Giriş Yapılıyor", "Doğrulandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form2 frm = new Form2();
                    frm.kullanıcısifre = txtsifre.Text;
                    frm.anahtar = this.anahtar;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş Yapılamadı Doğrulama Kodu Hatalı", "Doğrulanamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            kayıt = false;
        }

        private string kodumuz()
        {
            Random rnd = new Random();
            
            for (int i = 0; i < 6; i++)
            {
                sayılar[i] = rnd.Next(0, 10);
            }
            string sifre = "";
            for (int i = 0; i < 6; i++)
            {
                sifre += sayılar[i]; 
            }
            return sifre;
        }

        private void btnkaydol_Click(object sender, EventArgs e)
        {
            if (txtadı.Text == "" || txtsifre.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglantı.Close();
                baglantı.Open();
                OleDbCommand komut = new OleDbCommand("select * from tblkullanıcı where kullanıcıadı=@ad", baglantı);
                komut.Parameters.AddWithValue("@ad", txtadı.Text);
                OleDbDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    MessageBox.Show("Bu Mail Sistemde kayıtlı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    txtadı.ReadOnly = true;
                    txtsifre.ReadOnly = true;
                    kayıt = true;
                    mesajgönder();
                    label3.Visible = true; btnemail.Visible = true; txtemail.Visible = true;
                }
                baglantı.Close();
            }
        }

        private void btnunut_Click(object sender, EventArgs e)
        {
             if (txtadı.Text=="")
            {
                MessageBox.Show("Email Adresinizi Giriniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                baglantı.Close();
                baglantı.Open();
                OleDbCommand komut = new OleDbCommand("select * from tblkullanıcı where kullanıcıadı=@ad", baglantı);
                komut.Parameters.AddWithValue("@ad", txtadı.Text);
                OleDbDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    unutma = true;
                    string cozcen = oku["sifre"].ToString();
                    unutmus = cls.coz(cozcen, gzl.Crypto);
                    mesajgönder();
                    MessageBox.Show("Şifreniz Mail Adresinize Gönderildi", "GÖNDERİLDİ", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Bu Mail Sistemde kayıtlı değil", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
