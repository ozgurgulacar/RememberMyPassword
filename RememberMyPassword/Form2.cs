using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RememberMyPassword
{
    public partial class Form2 : Form
    {
        string id="";
        string secilen = "";
        public string kullanıcısifre="";
        public string anahtar="";
        int sayac = 0;
        public Form2()
        {
            InitializeComponent();
        }

        Class1 cls = new Class1();
        private void listele()
        {
            string liste2 = "select * from tblsifre where anahtar= '"+anahtar+"'";
            datamız.DataSource = cls.listeleme(liste2);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {

            if (txtplatform.Text == "" || txtsifre.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtRMP.Text==kullanıcısifre)
                {
                    try
                    {
                        string encrypt = cls.sifrele(txtsifre.Text, "ka12sdq43");
                        string komut = "insert into tblsifre(platform,sifre,anahtar) values('" + txtplatform.Text + "' , '" + encrypt + "' , '"+anahtar+"' )";
                        cls.ekleme(komut);
                        listele();
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    txtRMP.Text = "";
                }
                else
                {
                    MessageBox.Show("RememberMyPassword Uygulamasının Şifresi Yanlış", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            
        }

        private void datamız_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = datamız.CurrentRow.Cells[0].Value.ToString();
                secilen = datamız.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {

            }
            
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (id=="")
            {
                MessageBox.Show("Lütfen Listeden Birini Seçiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtRMP.Text==kullanıcısifre)
                {
                    try
                    {
                        string komut = "delete  from tblsifre where Kimlik= " + id;
                        cls.sil(komut);
                        listele();
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                     
                }
                else
                {
                    MessageBox.Show("RememberMyPassword Uygulamasının Şifresi Yanlış", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                txtRMP.Text = "";
            }
        }

        private void btnguncel_Click(object sender, EventArgs e)
        {
            if (id=="")
            {
                MessageBox.Show("Lütfen Listeden Birini Seçiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtRMP.Text==kullanıcısifre)
                {
                    if (txtplatform.Text==""|| txtsifre.Text=="")
                    {
                        MessageBox.Show("Lütfen Tüm Alanları Doldurunuz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string encrypt = cls.sifrele(txtsifre.Text, "ka12sdq43");
                        string komut = "update tblsifre set platform='"+txtplatform.Text+"' , sifre='"+ encrypt+"' where Kimlik=" + id;
                        cls.güncel(komut);
                        listele();
                    }
                }
                else
                {
                    MessageBox.Show("RememberMyPassword Uygulamasının Şifresi Yanlış", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtRMP.Text = "";
            }
        }

        private void btngöster_Click(object sender, EventArgs e)
        {
            if (txtRMP.Text==kullanıcısifre)
            {
                if (secilen=="")
                {
                    MessageBox.Show("Lütfen Listeden Birini Seçiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    sayac = 0;
                    timer1.Start();
                    string decrypt = cls.coz(secilen, "ka12sdq43");
                    lblsifre.Text = " SEÇİLEN SİFRE: " + decrypt + "  ";
                }
            }
            else
            {
                MessageBox.Show("RememberMyPassword Uygulamasının Şifresi Yanlış", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.kullanıcısifre = kullanıcısifre;
            frm.which = anahtar;
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac>15)
            {
                lblsifre.Text = " SEÇİLEN SİFRE: ";
                timer1.Stop();
            }
        }

        private void btnoner_Click(object sender, EventArgs e)
        {
            lbloneri.Text = "";
            Random rnd = new Random();
            for (int i = 0; i < 8; i++)
            {
                int kat = rnd.Next(0, 10);
                if (kat < 2)
                {
                    int isaret = rnd.Next(0,7);
                    if (isaret == 1)
                    {
                        lbloneri.Text += "!";
                    }
                    else if(isaret == 2)
                    { 
                        lbloneri.Text += "-";
                    }
                    else if (isaret == 3)
                    {
                        lbloneri.Text += "+";
                    }
                    else if (isaret == 4)
                    {
                        lbloneri.Text += "'";
                    }
                    else if (isaret == 5)
                    {
                        lbloneri.Text += "?";
                    }
                    else if (isaret == 6)
                    {
                        lbloneri.Text += "/";
                    }
                }
                else if (kat > 5)
                {
                    int kucuk = rnd.Next(97, 123);
                    char character = (char)kucuk;
                    lbloneri.Text += character.ToString();
                }
                else
                {
                    int buyuk = rnd.Next(65, 91);
                    char character = (char)buyuk;
                    lbloneri.Text += character.ToString();
                }
            }
            
        }
    }
}
