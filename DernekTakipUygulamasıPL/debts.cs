using BL;
using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DernekTakipUygulamasıPL
{
    public partial class debts : Form
    {
        public debts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DALdebt.ProcessAllDebts();

            bool isExistingMember = DALdebt.IsMemberExists(textBox1.Text);
            if (isExistingMember)
            {
                DialogResult result = MessageBox.Show("Kayıtı borcu istediğinize emin misiniz? \nSilmek üzeresiniz!", "Uyarı!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    
                    BLdebts.BLdeletedebt(textBox1.Text);
                    list();
                    
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) 
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                isTextChangedEventEnabled = false; // TextChanged olayını geçici olarak devre dışı bırak
                textBox1.Text = selectedRow.Cells["TC"].Value.ToString();
                namelbl.Text = selectedRow.Cells["Name"].Value.ToString()+ " "+ selectedRow.Cells["Surname"].Value.ToString();
                price.Text = selectedRow.Cells["DeptAmount"].Value.ToString()+" ₺";
                namelbl.Visible = true;
                price.Visible = true;
                isTextChangedEventEnabled = true; // TextChanged olayını tekrar etkinleştir
            }
            else
            {
                MessageBox.Show("Üye bulunamadı.");
            }
        }

        private bool isTextChangedEventEnabled = true;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!isTextChangedEventEnabled)
            {
                return;
            }

            List<ELDebt> eLDebts = DALdebt.debtSearch(textBox1.Text);
            dataGridView1.DataSource = eLDebts;
        }

        private void debts_Load(object sender, EventArgs e)
        {

            list();

        }

        public void list() 
        {
            List<ELDebt> debts = DALdebt.debtList();
            dataGridView1.DataSource = debts;
            dataGridView1.Columns["DeptAmount"].DefaultCellStyle.Format = "C2";
        }

        private void btnsendmail_Click(object sender, EventArgs e)
        {
            this.Hide();
            SendMail mail = new SendMail();
            mail.ShowDialog();
            this.Show();

        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            
            BLpdf pdfExporter = new BLpdf();
            pdfExporter.ExportPdf(dataGridView1);

        }


    }
}

