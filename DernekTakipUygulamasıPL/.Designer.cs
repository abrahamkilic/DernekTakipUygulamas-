namespace DernekTakipUygulamasıPL
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.ComboBlood = new System.Windows.Forms.ComboBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtphone = new System.Windows.Forms.MaskedTextBox();
            this.btnGroupbyBloodList = new System.Windows.Forms.Button();
            this.cmbfiltrByGroup = new System.Windows.Forms.ComboBox();
            this.cmbfiltercity = new System.Windows.Forms.ComboBox();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.btnGroupByCities = new System.Windows.Forms.Button();
            this.cmbSituation = new System.Windows.Forms.ComboBox();
            this.btnSituation = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tclbl = new System.Windows.Forms.Label();
            this.lblAD = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblKan = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aktif = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(185, 680);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 55);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(10, 680);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 55);
            this.btnUpdate.TabIndex = 54;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ComboBlood
            // 
            this.ComboBlood.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBlood.FormattingEnabled = true;
            this.ComboBlood.Location = new System.Drawing.Point(108, 152);
            this.ComboBlood.Name = "ComboBlood";
            this.ComboBlood.Size = new System.Drawing.Size(200, 21);
            this.ComboBlood.TabIndex = 50;
            // 
            // txtAdres
            // 
            this.txtAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdres.Location = new System.Drawing.Point(109, 315);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(200, 54);
            this.txtAdres.TabIndex = 49;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(108, 236);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 35;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoyad.Location = new System.Drawing.Point(109, 108);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 20);
            this.txtSoyad.TabIndex = 34;
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.SystemColors.Window;
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAd.Location = new System.Drawing.Point(108, 67);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 20);
            this.txtAd.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(340, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1102, 672);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 619);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 55);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTC
            // 
            this.txtTC.BackColor = System.Drawing.SystemColors.Window;
            this.txtTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTC.Location = new System.Drawing.Point(108, 29);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(200, 20);
            this.txtTC.TabIndex = 32;
            this.txtTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_KeyPress);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(185, 619);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(145, 55);
            this.btnListele.TabIndex = 56;
            this.btnListele.Text = "listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtphone
            // 
            this.txtphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtphone.Location = new System.Drawing.Point(109, 191);
            this.txtphone.Mask = "(999) 000-0000";
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(199, 20);
            this.txtphone.TabIndex = 57;
            // 
            // btnGroupbyBloodList
            // 
            this.btnGroupbyBloodList.Location = new System.Drawing.Point(164, 580);
            this.btnGroupbyBloodList.Name = "btnGroupbyBloodList";
            this.btnGroupbyBloodList.Size = new System.Drawing.Size(144, 23);
            this.btnGroupbyBloodList.TabIndex = 58;
            this.btnGroupbyBloodList.Text = "Kan grubuna göre listele";
            this.btnGroupbyBloodList.UseVisualStyleBackColor = true;
            this.btnGroupbyBloodList.Click += new System.EventHandler(this.btnGroupbyBloodList_Click);
            // 
            // cmbfiltrByGroup
            // 
            this.cmbfiltrByGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbfiltrByGroup.FormattingEnabled = true;
            this.cmbfiltrByGroup.Location = new System.Drawing.Point(8, 93);
            this.cmbfiltrByGroup.Name = "cmbfiltrByGroup";
            this.cmbfiltrByGroup.Size = new System.Drawing.Size(137, 21);
            this.cmbfiltrByGroup.TabIndex = 59;
            // 
            // cmbfiltercity
            // 
            this.cmbfiltercity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbfiltercity.FormattingEnabled = true;
            this.cmbfiltercity.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Istanbul",
            "Izmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cmbfiltercity.Location = new System.Drawing.Point(8, 16);
            this.cmbfiltercity.Name = "cmbfiltercity";
            this.cmbfiltercity.Size = new System.Drawing.Size(137, 21);
            this.cmbfiltercity.TabIndex = 60;
            // 
            // cmbSehir
            // 
            this.cmbSehir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Istanbul",
            "Izmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cmbSehir.Location = new System.Drawing.Point(109, 276);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(199, 21);
            this.cmbSehir.TabIndex = 61;
            // 
            // btnGroupByCities
            // 
            this.btnGroupByCities.Location = new System.Drawing.Point(164, 504);
            this.btnGroupByCities.Name = "btnGroupByCities";
            this.btnGroupByCities.Size = new System.Drawing.Size(144, 22);
            this.btnGroupByCities.TabIndex = 62;
            this.btnGroupByCities.Text = "Şehre göre listele";
            this.btnGroupByCities.UseVisualStyleBackColor = true;
            this.btnGroupByCities.Click += new System.EventHandler(this.btnGroupByCities_Click);
            // 
            // cmbSituation
            // 
            this.cmbSituation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSituation.FormattingEnabled = true;
            this.cmbSituation.Items.AddRange(new object[] {
            "aktif",
            "pasif"});
            this.cmbSituation.Location = new System.Drawing.Point(8, 57);
            this.cmbSituation.Name = "cmbSituation";
            this.cmbSituation.Size = new System.Drawing.Size(137, 21);
            this.cmbSituation.TabIndex = 69;
            // 
            // btnSituation
            // 
            this.btnSituation.Location = new System.Drawing.Point(164, 544);
            this.btnSituation.Name = "btnSituation";
            this.btnSituation.Size = new System.Drawing.Size(144, 23);
            this.btnSituation.TabIndex = 70;
            this.btnSituation.Text = "Aktif/Pasif";
            this.btnSituation.UseVisualStyleBackColor = true;
            this.btnSituation.Click += new System.EventHandler(this.btnSituation_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tclbl
            // 
            this.tclbl.AutoSize = true;
            this.tclbl.BackColor = System.Drawing.Color.Transparent;
            this.tclbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tclbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tclbl.Location = new System.Drawing.Point(12, 32);
            this.tclbl.Name = "tclbl";
            this.tclbl.Size = new System.Drawing.Size(70, 15);
            this.tclbl.TabIndex = 37;
            this.tclbl.Text = "TC Kimlik No";
            // 
            // lblAD
            // 
            this.lblAD.AutoSize = true;
            this.lblAD.Location = new System.Drawing.Point(12, 66);
            this.lblAD.Name = "lblAD";
            this.lblAD.Size = new System.Drawing.Size(20, 13);
            this.lblAD.TabIndex = 38;
            this.lblAD.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(12, 108);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 39;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblKan
            // 
            this.lblKan.AutoSize = true;
            this.lblKan.Location = new System.Drawing.Point(10, 151);
            this.lblKan.Name = "lblKan";
            this.lblKan.Size = new System.Drawing.Size(55, 13);
            this.lblKan.TabIndex = 40;
            this.lblKan.Text = "kan grubu";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(10, 194);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(39, 13);
            this.lblTelefon.TabIndex = 41;
            this.lblTelefon.Text = "Tel No";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 235);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 42;
            this.lblEmail.Text = "E-mail";
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Location = new System.Drawing.Point(12, 275);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(31, 13);
            this.lblSehir.TabIndex = 43;
            this.lblSehir.Text = "Şehir";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(10, 314);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 44;
            this.lblAdres.Text = "Adres";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 383);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 67;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Üyelik Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 66;
            this.label2.Text = "aktiflik durumu";
            // 
            // aktif
            // 
            this.aktif.AutoSize = true;
            this.aktif.Location = new System.Drawing.Point(109, 448);
            this.aktif.Name = "aktif";
            this.aktif.Size = new System.Drawing.Size(46, 17);
            this.aktif.TabIndex = 64;
            this.aktif.Text = "aktif";
            this.aktif.UseVisualStyleBackColor = true;
            this.aktif.CheckedChanged += new System.EventHandler(this.aktif_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Aidat";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(109, 421);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 71;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 1030);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aktif);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 471);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "üye ekle";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(536, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(457, 797);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(985, -74);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(512, 836);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 75;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbfiltercity);
            this.groupBox2.Controls.Add(this.cmbSituation);
            this.groupBox2.Controls.Add(this.cmbfiltrByGroup);
            this.groupBox2.Location = new System.Drawing.Point(10, 489);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 124);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "arama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 758);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSituation);
            this.Controls.Add(this.btnGroupByCities);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSehir);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblSehir);
            this.Controls.Add(this.btnGroupbyBloodList);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.lblKan);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblAD);
            this.Controls.Add(this.ComboBlood);
            this.Controls.Add(this.tclbl);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox ComboBlood;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.MaskedTextBox txtphone;
        private System.Windows.Forms.Button btnGroupbyBloodList;
        private System.Windows.Forms.ComboBox cmbfiltrByGroup;
        private System.Windows.Forms.ComboBox cmbfiltercity;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.Button btnGroupByCities;
        private System.Windows.Forms.ComboBox cmbSituation;
        private System.Windows.Forms.Button btnSituation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label tclbl;
        private System.Windows.Forms.Label lblAD;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblKan;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox aktif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

