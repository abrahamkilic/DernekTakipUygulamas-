using BL;
using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DernekTakipUygulamasıPL
{
    public partial class setDues : Form
    {
        public setDues()
        {
            InitializeComponent();
        }

        private void btnSET_Click(object sender, EventArgs e)
        {
            ELDues setdues = new ELDues();
            if (!string.IsNullOrEmpty(pricetxt.Text))
            {
                setdues.PayAmount = decimal.Parse(pricetxt.Text);
                //setdues.DuesMonth = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 15);
                BLdues.BLsetdues(setdues);
                ELMember member = new ELMember();
                member.Dues = decimal.Parse(pricetxt.Text);
                BLmember.BLsetDuesMember(member);

                pricetxt.Clear();
                List();
            }
            else
            {
                MessageBox.Show("Lütfen bir değer girin");
            }
            
        }

        private void setDues_Load(object sender, EventArgs e)
        {
            List();  
        }

        void List()
        {
            List<ELDues> dues1 = DALdues.GetAllDues();
            dataGridView1.DataSource = dues1;
            dataGridView1.Columns["PayAmount"].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns["DuesMonth"].DefaultCellStyle.Format = "MMMM-yyyy";

        }

    }
}
