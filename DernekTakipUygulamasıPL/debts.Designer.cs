namespace DernekTakipUygulamasıPL
{
    partial class debts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(debts));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.namelbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.btnsendmail = new System.Windows.Forms.Button();
            this.btnpdf = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(367, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 467);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toplam Borç";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(21, 86);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(80, 22);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Ad Soyad";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(25, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 66);
            this.button1.TabIndex = 4;
            this.button1.Text = "borç öde";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // namelbl
            // 
            this.namelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.namelbl.Location = new System.Drawing.Point(135, 86);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(216, 23);
            this.namelbl.TabIndex = 5;
            this.namelbl.Text = "label3";
            this.namelbl.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(135, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // price
            // 
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.price.Location = new System.Drawing.Point(135, 139);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(216, 31);
            this.price.TabIndex = 7;
            this.price.Text = "label3";
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.price.Visible = false;
            // 
            // btnsendmail
            // 
            this.btnsendmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsendmail.Location = new System.Drawing.Point(215, 201);
            this.btnsendmail.Name = "btnsendmail";
            this.btnsendmail.Size = new System.Drawing.Size(134, 66);
            this.btnsendmail.TabIndex = 8;
            this.btnsendmail.Text = "Borçulara mail gönder";
            this.btnsendmail.UseVisualStyleBackColor = true;
            this.btnsendmail.Click += new System.EventHandler(this.btnsendmail_Click);
            // 
            // btnpdf
            // 
            this.btnpdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpdf.Location = new System.Drawing.Point(25, 289);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(134, 66);
            this.btnpdf.TabIndex = 9;
            this.btnpdf.Text = "PDF indir";
            this.btnpdf.UseVisualStyleBackColor = true;
            this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 493);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // debts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 491);
            this.Controls.Add(this.btnpdf);
            this.Controls.Add(this.btnsendmail);
            this.Controls.Add(this.price);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "debts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "debts";
            this.Load += new System.EventHandler(this.debts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Button btnsendmail;
        private System.Windows.Forms.Button btnpdf;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}