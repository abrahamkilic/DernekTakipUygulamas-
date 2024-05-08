namespace DernekTakipUygulamasıPL
{
    partial class SendMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbody = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsendmail = new System.Windows.Forms.Button();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnaddDocuments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsubject
            // 
            this.txtsubject.Location = new System.Drawing.Point(135, 35);
            this.txtsubject.Multiline = true;
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(561, 51);
            this.txtsubject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başlık";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbody
            // 
            this.txtbody.Location = new System.Drawing.Point(135, 106);
            this.txtbody.Multiline = true;
            this.txtbody.Name = "txtbody";
            this.txtbody.Size = new System.Drawing.Size(561, 281);
            this.txtbody.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(8, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "İçerik";
            // 
            // btnsendmail
            // 
            this.btnsendmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsendmail.Location = new System.Drawing.Point(12, 445);
            this.btnsendmail.Name = "btnsendmail";
            this.btnsendmail.Size = new System.Drawing.Size(684, 73);
            this.btnsendmail.TabIndex = 4;
            this.btnsendmail.Text = "Toplu mail gönder";
            this.btnsendmail.UseVisualStyleBackColor = true;
            this.btnsendmail.Click += new System.EventHandler(this.btnsendmail_Click);
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(211, 407);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(485, 20);
            this.txtfilename.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dosya ekle";
            // 
            // btnaddDocuments
            // 
            this.btnaddDocuments.Location = new System.Drawing.Point(135, 405);
            this.btnaddDocuments.Name = "btnaddDocuments";
            this.btnaddDocuments.Size = new System.Drawing.Size(70, 23);
            this.btnaddDocuments.TabIndex = 7;
            this.btnaddDocuments.Text = "Dosya ekle";
            this.btnaddDocuments.UseVisualStyleBackColor = true;
            this.btnaddDocuments.Click += new System.EventHandler(this.btnaddDocuments_Click);
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 546);
            this.Controls.Add(this.btnaddDocuments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.btnsendmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbody);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsubject);
            this.Name = "SendMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbody;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsendmail;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnaddDocuments;
    }
}