// DernekTakipUygulamasıPL ad alanında yer alan Dues sınıfı, aidat işlemlerini takip etmek 
// ve yönetmek için kullanılan bir Windows Forms formunu temsil eder.

using BL; // İş Mantığı Katmanı (Business Logic) ile ilgili sınıfların kullanılabilmesi için
using DAL; // Veri Erişim Katmanı (Data Access Layer) ile ilgili sınıfların kullanılabilmesi için
using EL; // Varlık Katmanı (Entity Layer) ile ilgili sınıfların kullanılabilmesi için
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DernekTakipUygulamasıPL
{
    public partial class Dues : Form
    {
        public Dues()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // Aidat ödeme işlemi için gerekli bilgileri içeren bir ELDues nesnesi
            // oluşturulur.
            ELDues dues = new ELDues();          
            dues.Paid = true;
            dues.PaidDate = DateTime.Now;
            dues.DuesID=Convert.ToInt32(makbuz.Text);
            // BLdues sınıfındaki BLPayDues metodu çağrılarak aidat ödeme işlemi
            // gerçekleştirilir.
            int updatedRows = BLdues.BLPayDues(dues);
            // Eğer en az bir kayıt güncellendiyse, işlem başarılı kabul edilir ve
            // güncellenmiş
            // aidat listesi DataGridView kontrolüne yüklenir.
            if (updatedRows > 0)
            {
                // Başarıyla eklendi
                List<ELDues> dues1 = DALdues.GetAllDues();
                dataGridView1.DataSource = dues1;
                Format();
            }

            MessageBox.Show("Aidat ödenmiştir");
            Clear();

        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            // TextChanged olayının geçici olarak devre dışı bırakılması durumunda,
            // bu metodun 
            // işlemesi engellenir.
            if (!isTextChangedEventEnabled)
            {
                return;
            }
            // DALdues sınıfındaki DuesSearch metodu çağrılarak, belirli bir TC numarasına
            // sahip üyenin aidat bilgileri alınır ve DataGridView kontrolüne yüklenir.
            List<ELDues> members = DALdues.DuesSearch(txtTC.Text);
            dataGridView1.DataSource = members;
            Format();
        }

        private void btnUnpaid_Click(object sender, EventArgs e)
        {
            // DALdues sınıfındaki ListUnpaid metodu çağrılarak, ödenmemiş aidat listesi 
            // DataGridView kontrolüne yüklenir.
            List<ELDues> dues1 = DALdues.ListUnpaid();
            dataGridView1 .DataSource = dues1;
            Format();
            Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Satırın geçerli bir satır olduğundan emin olunur.
            if (e.RowIndex >= 0 ) // Satırın geçerli bir satır olduğundan emin olun
            {
                // Seçilen satırdaki bilgiler alınarak ekranda gösterilir.
                // tıklanan satırın bilgileri gerekli alanlara doldudurulur.
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                isTextChangedEventEnabled = false; // TextChanged olayını geçici
                                                   // olarak devre dışı bırak
                txtTC.Text = selectedRow.Cells["TC"].Value.ToString();
                lblname.Text= selectedRow.Cells["Name"].Value.ToString()  +" " +
                    selectedRow.Cells["Surname"].Value.ToString();
                makbuz.Text = selectedRow.Cells["DuesID"].Value.ToString();
                lblname.Visible = true;
                makbuz.Visible=true;
                DateTime duesMonth = (DateTime)selectedRow.Cells["DuesMonth"].Value;
                price.Text = selectedRow.Cells["PayAmount"].Value.ToString() + "₺\n" +
                    duesMonth.ToString("MMMM-yyyy") ;
   
                
                price.Visible = true;
                bool paid = (bool)selectedRow.Cells["Paid"].Value;
                
                isTextChangedEventEnabled = true;
                // Eğer aidat ödenmişse, ödeme bilgisini gösteren bir mesaj kutusu
                // görüntülenir.
                if (paid == true)
                {
                    price.Visible = true;
                    price.Text = "00,00";
                    
                    MessageBox.Show("Bu makbuz ödenmiştir.");
                }
            }
            else
            {
                MessageBox.Show("Aidat bilgisi bulunamadı.");
            }
        }

        private bool isTextChangedEventEnabled = true;

        private void btnPaidList_Click(object sender, EventArgs e)
        {
            // DALdues sınıfındaki ListPaid metodu çağrılarak, ödenmiş aidat listesi 
            // DataGridView kontrolüne yüklenir.
            List<ELDues> dues1 = DALdues.ListPaid();
            dataGridView1.DataSource = dues1;
            Format();
            Clear();
        }

        private void cmbMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ComboBox'tan seçilen ay değerine göre aidat listesi filtrelenir ve 
            // DataGridView kontrolüne yüklenir.
            if (cmbMonths.SelectedItem != null)
            {
                string selectedMonths = cmbMonths.SelectedItem.ToString();              
                List<ELDues> dues1 = DALdues.ListPaymenByMonths(selectedMonths);
                dataGridView1.DataSource = dues1;
                Format();
            }
            else
            {
                // ComboBox seçili değilse uyarı mesajı gösterilir.
                MessageBox.Show("Lütfen bir öğe seçin!");
            }
        }

        private void Clear()
        {
            // Kullanıcı arayüzündeki bazı kontroller temizlenir ve gizlenir.
            txtTC.Clear();
            lblname.Visible = false;
            makbuz.Visible = false;
            price.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Belirli tarihler arasındaki aidatları getirmek için bir metot çağrılır.
            DateTime baslangicTarihFormati = dateTimePicker1.Value;
            DateTime endDateFormat =dateTimePicker2.Value;
            // Metodu çağırma
            List<ELDues> dues1 = 
                DALdues.BelirliTarihlerArasindakiDues(baslangicTarihFormati, endDateFormat);

            dataGridView1.DataSource = dues1;
            Format();
        }

        private void Dues_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde, tüm aidat bilgilerini getirerek DataGridView kontrolüne
            // yüklenir.
            List<ELDues> dues1 = DALdues.GetAllDues();
            dataGridView1.DataSource = dues1;
            Format();
        }

        void Format() 
        {
            // DataGridView kontrolünün görüntüsünü düzenleyen Format metodu.
            dataGridView1.Columns["PayAmount"].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns["DuesMonth"].DefaultCellStyle.Format = "MMMM-yyyy";
        }
    }
}

