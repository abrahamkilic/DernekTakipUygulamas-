using BL;
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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 memberscreen = new Form1();
            memberscreen.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dues duescreen = new Dues();
            duescreen.ShowDialog();
            this.Show();


        }

        private void admin_Load(object sender, EventArgs e)
        {
            BLmember.BLupdateSituation();
            BLdebts.BLProcessAllDebts(); 
        }

        private void BtnGraph_Click(object sender, EventArgs e)
        {
            this.Hide();
            Graph mail = new Graph();
            mail.ShowDialog();
            this.Show();
        }


        private void BtnSetDues_Click(object sender, EventArgs e)
        {
            this.Hide();
            setDues setduescreen = new setDues();
            setduescreen.ShowDialog();
            this.Show();
        }

        private void BtnDebts_Click(object sender, EventArgs e)
        {
            this.Hide();
            debts debtsscreen = new debts();
            debtsscreen.ShowDialog();
            this.Show();
        }

        private void admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış yapmak üzeresiniz\n çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.No)
            {
                
            }
        }
    }
}
