namespace DernekTakipUygulamasıPL
{
    partial class Dues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dues));
            this.btnPay = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPaidList = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.makbuz = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.Label();
            this.cmbMonths = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUnpaid = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(10, 273);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(250, 50);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "öde";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(285, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(906, 454);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(129, 30);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(141, 20);
            this.txtTC.TabIndex = 2;
            this.txtTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC kimlik numarası";
            // 
            // btnPaidList
            // 
            this.btnPaidList.Location = new System.Drawing.Point(13, 339);
            this.btnPaidList.Name = "btnPaidList";
            this.btnPaidList.Size = new System.Drawing.Size(115, 50);
            this.btnPaidList.TabIndex = 6;
            this.btnPaidList.Text = "ödenmişleri görüntüle";
            this.btnPaidList.UseVisualStyleBackColor = true;
            this.btnPaidList.Click += new System.EventHandler(this.btnPaidList_Click);
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.SystemColors.Window;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.price.Location = new System.Drawing.Point(123, 197);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(147, 53);
            this.price.TabIndex = 22;
            this.price.Text = "MakbuzID";
            this.price.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tutar-Dönem";
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblname.Location = new System.Drawing.Point(132, 72);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(138, 80);
            this.lblname.TabIndex = 20;
            this.lblname.Text = "MakbuzID";
            this.lblname.Visible = false;
            // 
            // makbuz
            // 
            this.makbuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.makbuz.Location = new System.Drawing.Point(125, 152);
            this.makbuz.Name = "makbuz";
            this.makbuz.Size = new System.Drawing.Size(145, 24);
            this.makbuz.TabIndex = 19;
            this.makbuz.Text = "MakbuzID";
            this.makbuz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.makbuz.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Makbuz Numarası";
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad.Location = new System.Drawing.Point(12, 78);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(68, 16);
            this.ad.TabIndex = 17;
            this.ad.Text = "Ad-Soyad";
            // 
            // cmbMonths
            // 
            this.cmbMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMonths.FormattingEnabled = true;
            this.cmbMonths.Items.AddRange(new object[] {
            "OCAK",
            "ŞUBAT",
            "MART",
            "NİSAN",
            "MAYIS",
            "HAZİRAN",
            "TEMMUZ",
            "AĞUSTOS",
            "EYLÜL",
            "EKİM",
            "KASIM",
            "ARALIK"});
            this.cmbMonths.Location = new System.Drawing.Point(850, 13);
            this.cmbMonths.Name = "cmbMonths";
            this.cmbMonths.Size = new System.Drawing.Size(341, 28);
            this.cmbMonths.TabIndex = 23;
            this.cmbMonths.SelectedIndexChanged += new System.EventHandler(this.cmbMonths_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(796, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "dönem";
            // 
            // btnUnpaid
            // 
            this.btnUnpaid.Location = new System.Drawing.Point(143, 339);
            this.btnUnpaid.Name = "btnUnpaid";
            this.btnUnpaid.Size = new System.Drawing.Size(117, 50);
            this.btnUnpaid.TabIndex = 25;
            this.btnUnpaid.Text = "Ödenmemişleri görüntüle";
            this.btnUnpaid.UseVisualStyleBackColor = true;
            this.btnUnpaid.Click += new System.EventHandler(this.btnUnpaid_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 426);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 26);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(15, 426);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(115, 26);
            this.dateTimePicker2.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(16, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "başlangıç tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(161, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "bitiş tarihi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 45);
            this.button1.TabIndex = 30;
            this.button1.Text = "tarihler arası ödeme listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-154, -173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1620, 902);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Dues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1203, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnUnpaid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMonths);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.makbuz);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.btnPaidList);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dues";
            this.Load += new System.EventHandler(this.Dues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPaidList;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label makbuz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.ComboBox cmbMonths;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUnpaid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}