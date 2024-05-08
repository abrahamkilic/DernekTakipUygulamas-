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
    public partial class SendMail : Form
    {
        public SendMail()
        {
            InitializeComponent();
        }

        private void btnaddDocuments_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "gönderi için dosya seçebilirsiniz";
            ofd.ShowDialog();
            txtfilename.Text = ofd.FileName;

        }

        private void btnsendmail_Click(object sender, EventArgs e)
        {
            string subject;
            string bodyTemplate;
            string file = txtfilename.Text;
            string someOtherValue = null;

            if (string.IsNullOrEmpty(txtbody.Text))
            {
                bodyTemplate = "Merhaba {1} {2},\n\n Borcunuz {0} ₺ tutarındadır. Lütfen en kısa sürede ödeme yapınız.";
            }
            else
            {
                bodyTemplate = txtbody.Text;
            }
            if (string.IsNullOrEmpty(txtsubject.Text))
            {
                subject = "Borç Bilgilendirme";
            }
            else
            {
                subject = txtsubject.Text;
            }

            BLEmailSender.SendAutomaticEmails(subject, bodyTemplate, someOtherValue, file);
        }
    }
}
