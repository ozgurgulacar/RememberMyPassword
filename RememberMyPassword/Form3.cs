using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RememberMyPassword
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string kullanıcısifre="1234";
        public string which="";
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (txtadı.Text == "" || txtsifre.Text == "" || txteski.Text=="")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txteski.Text==kullanıcısifre)
                {
                    try
                    {
                        Class1 cls = new Class1();
                        string encrypt = cls.sifrele(txtsifre.Text, "ka12sdq43");
                        string komut = "update tblkullanıcı set kullanıcıadı='" + txtadı.Text + "' , sifre='" + encrypt + "' where anahtar='"+which+"'";
                        cls.güncel(komut);
                        MessageBox.Show("Güncelleme İşlemi Başarılı", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
            }
        }
    }
}
