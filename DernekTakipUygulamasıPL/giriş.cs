using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DernekTakipUygulamasıPL
{
    public partial class giriş : Form
    {
        public giriş()
        {
            InitializeComponent();
            InitializeTextBox();
        }

        private void InitializeTextBox()
        {

            username.Text = "Kullanıcı Adı"; // Varsayılan metin
            username.ForeColor = Color.Gray; // Saydam yazı rengi
            pass.Text = "Kullanıcı Adı"; // Varsayılan metin
            pass.ForeColor = Color.Gray; // Saydam yazı rengi
        }


        private void TextBox1_GotFocus(object sender, EventArgs e)
        {
            username.Text = "";
            
        }
        private void TextBox2_GotFocus(object sender, EventArgs e)
        {
            pass.Text = "";
           
        }

        private void giriş_Load(object sender, EventArgs e)
        {
            username.Click += new EventHandler(TextBox1_GotFocus);
            pass.Click += new EventHandler(TextBox2_GotFocus);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = username.Text;
            string sifre = pass.Text;

            // Kullanıcı adı ve şifre kontrolü
            if (Dogrula(kullaniciAdi, sifre))
            {
                MessageBox.Show("Giriş Başarılı!");
                this.Hide();
                admin adminscreen = new admin();
                adminscreen.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }

            

        }

        private bool Dogrula(string kullaniciAdi, string sifre)
        {
            // Burada gerçek bir doğrulama mekanizması kullanmanız gerekebilir.
            // Örneğin, veritabanına bağlanarak kullanıcı adı ve şifre kontrolü yapabilirsiniz.
            // Bu örnekte sadece basit bir şart kontrolü yapılmıştır.
            if (kullaniciAdi == "admin" && sifre == "1234")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
