using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using EL;
using BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Data.OleDb;
using System.Data.Common;
using System.Data.Odbc;

namespace DernekTakipUygulamasıPL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string girilenDeger = txtTC.Text;
            txtTC.MaxLength = 11;
            if (girilenDeger.Length == 11)
            {

                ELMember mem = new ELMember();

                if (decimal.TryParse(textBox1.Text, out decimal parsedValue))
                {
                    // Eğer dönüşüm başarılı ise mem.Dues'e atama
                    mem.Dues = parsedValue;
                }
                mem.TC = txtTC.Text;
                mem.NAME = txtAd.Text;
                mem.SURNAME = txtSoyad.Text;
                mem.PhoneNumber = txtphone.Text;
                mem.BloodGroup = ComboBlood.Text;
                mem.MailAdress = txtEmail.Text;
                mem.City = cmbSehir.Text;
                mem.Adress = txtAdres.Text;
                mem.Situation = aktif.Checked;
                mem.PaySituation = true;
                mem.MemberDate = dateTimePicker1.Value;
                mem.Dues = parsedValue;
                


                BLmember.BLaddmember(mem);

                List<ELMember> members = DALmember.memberList();
                dataGridView1.DataSource = members;
                Clear();
                list();

            }
            else
            {
                MessageBox.Show("11 haneli tc giriniz");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool isExistingMember = DALmember.IsMemberExists(txtTC.Text);
            if (isExistingMember)
            {
                DialogResult result = MessageBox.Show("Kayıtı silmek istediğinize emin misiniz? \nSilmek üzeresiniz!", "Uyarı!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    ELMember member = new ELMember();
                    member.TC = txtTC.Text;
                    BLmember.BLdeletemember(member.TC);
                    
                    Clear();
                    list();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ELMember mem = new ELMember();
            mem.TC = txtTC.Text;
            mem.NAME = txtAd.Text;
            mem.SURNAME = txtSoyad.Text;
            mem.PhoneNumber = txtphone.Text;
            mem.BloodGroup = ComboBlood.Text;
            mem.MailAdress = txtEmail.Text;
            mem.City = cmbSehir.Text;
            mem.Adress = txtAdres.Text;
            mem.Situation = aktif.Checked;
            
            mem.MemberDate = dateTimePicker1.Value;


            BLmember.BLupdateMembers(mem);
            Clear();
            list();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            list();
        }

        private void btnGroupbyBloodList_Click(object sender, EventArgs e)
        {

            if (cmbfiltrByGroup.SelectedItem != null)
            {
                string selectedBloodGroup = cmbfiltrByGroup.SelectedItem.ToString();

                // MemberService sınıfındaki GetMembersByBloodGroup metodu ile filtreleme yap
                List<ELMember> filteredMembers = DALmember.GetBloodGroup(selectedBloodGroup);

                // Filtrelenmiş üyeleri kullan
                // Örneğin, DataGridView veya başka bir kontrolü güncelleyebilirsiniz
                dataGridView1.DataSource = filteredMembers;
                cmbfiltrByGroup.SelectedIndex = -1;
            }
            else
            {
                // ComboBox seçili değilse uyarı mesajını göster
                MessageBox.Show("Lütfen bir öğe seçin!");
            }

        }

        private void btnGroupByCities_Click(object sender, EventArgs e)
        {
            if (cmbfiltercity.SelectedItem != null)
            {
                string selectedcity = cmbfiltercity.SelectedItem.ToString();

                // MemberService sınıfındaki GetMembersByCities metodu ile filtreleme yap
                List<ELMember> filteredMembers = DALmember.GetByCities(selectedcity);

                // Filtrelenmiş üyeleri kullan
                // Örneğin, DataGridView veya başka bir kontrolü güncelleyebilirsiniz
                dataGridView1.DataSource = filteredMembers;
                cmbfiltercity.SelectedIndex = -1;
            }
            else
            {
                // ComboBox seçili değilse uyarı mesajını göster
                MessageBox.Show("Lütfen bir öğe seçin!");
            }

        }

        private void btnSituation_Click(object sender, EventArgs e)
        {
            if (cmbSituation.SelectedItem != null)
            {
                // ComboBox'tan seçilen öğeyi al
                string selectedSituation = cmbSituation.SelectedItem.ToString();

                // Eğer seçilen durum "aktif" ise 1 olanları getir, değilse 0 olanları getir
                bool durumFiltre = (selectedSituation == "aktif");

                // MemberService sınıfındaki GetMembersByCities metodu ile filtreleme yap
                List<ELMember> filteredMembers = DALmember.GetBySituation(durumFiltre);

                // Filtrelenmiş üyeleri kullan
                // Örneğin, DataGridView veya başka bir kontrolü güncelleyebilirsiniz

                var selectedColumns = filteredMembers.Select(member => new
                {
                    member.TC,
                    member.NAME,
                    member.SURNAME,
                    member.PhoneNumber,
                    member.MailAdress,
                    member.Situation,
                    member.PaySituation
                }).ToList();

                // Filtrelenmiş üyeleri kullan
                // Örneğin, DataGridView veya başka bir kontrolü güncelleyebilirsiniz
                dataGridView1.DataSource = selectedColumns;
                cmbSituation.SelectedIndex = -1;
            }
            else
            {
                // ComboBox seçili değilse uyarı mesajını göster
                MessageBox.Show("Lütfen bir öğe seçin!");
            }
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            txtTC.MaxLength = 11;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] BloodGroup = { "A Rh+", "A Rh-", "B Rh+", "B Rh-", "AB Rh+", "AB Rh-", "0 Rh+", "0 Rh-" };

            // Kan gruplarını ComboBox'a ekleme
            ComboBlood.Items.AddRange(BloodGroup);
            cmbfiltrByGroup.Items.AddRange(BloodGroup);
            // TextBox1.Text değeri bir string olarak kabul edildi. Eğer değer başka bir veri tipindeyse ona uygun bir dönüşüm yapmalısınız.
           dataGridView1.Visible = false;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");

            if (selectedDate > DateTime.Now)
            {
                MessageBox.Show("Gelecek bir tarih seçtiniz. Lütfen geçmiş bir tarih seçiniz.");
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            if (!isTextChangedEventEnabled)
            {
                return;
            }

            List<ELMember> members = DALmember.memberSearch(txtTC.Text);
            dataGridView1.DataSource = members;
        }   

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.RowIndex >= 0) // Satırın geçerli bir satır olduğundan emin olun
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                isTextChangedEventEnabled = false; // TextChanged olayını geçici olarak devre dışı bırak
                txtTC.Text = selectedRow.Cells["TC"].Value.ToString();
                txtAd.Text = selectedRow.Cells["NAME"].Value.ToString();
                txtSoyad.Text = selectedRow.Cells["SURNAME"].Value.ToString();
                txtphone.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["MailAdress"].Value.ToString();
                txtAdres.Text = selectedRow.Cells["Adress"].Value.ToString();
                cmbSehir.Text = selectedRow.Cells["City"].Value.ToString();
                ComboBlood.Text = selectedRow.Cells["BloodGroup"].Value.ToString();
                
                aktif.Checked = Convert.ToBoolean(selectedRow.Cells["PaySituation"].Value);
                dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells["MemberDate"].Value);
                textBox1.Text = selectedRow.Cells["Dues"].Value.ToString();
                isTextChangedEventEnabled = true; // TextChanged olayını tekrar etkinleştir
            }
            else
            {
                // Arama sonucunda üye bulunamadıysa, gerekli işlemleri yapabilirsiniz.
                MessageBox.Show("Üye bulunamadı.");
                // TextBox'ları temizleme veya başka bir işlem yapabilirsiniz.
            }
        }

        private bool isTextChangedEventEnabled = true;

        private void Clear() 
        {
            txtTC.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtAdres.Clear();
            txtEmail.Clear();
            txtphone.Clear();
            cmbSehir.Items.Clear();
            cmbSituation.Items.Clear();
            
            aktif.Checked = false;
            dateTimePicker1.Value=DateTime.Now;
            textBox1.Clear();
        }

        private void list() 
        {
            dataGridView1.Visible = true;
            List<ELMember> members = DALmember.memberList();
            dataGridView1.DataSource = members;
            dataGridView1.Columns["Dues"].DefaultCellStyle.Format = "C2";
        }

        private void aktif_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
