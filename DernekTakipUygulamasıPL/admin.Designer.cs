namespace DernekTakipUygulamasıPL
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.button1 = new System.Windows.Forms.Button();
            this.BtnPayDues = new System.Windows.Forms.Button();
            this.BtnDebts = new System.Windows.Forms.Button();
            this.BtnGraph = new System.Windows.Forms.Button();
            this.BtnSetDues = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(78, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "üye işlemleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnPayDues
            // 
            this.BtnPayDues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPayDues.Location = new System.Drawing.Point(283, 111);
            this.BtnPayDues.Name = "BtnPayDues";
            this.BtnPayDues.Size = new System.Drawing.Size(165, 80);
            this.BtnPayDues.TabIndex = 1;
            this.BtnPayDues.Text = "Aidat ödeme";
            this.BtnPayDues.UseVisualStyleBackColor = true;
            this.BtnPayDues.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnDebts
            // 
            this.BtnDebts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDebts.Location = new System.Drawing.Point(490, 111);
            this.BtnDebts.Name = "BtnDebts";
            this.BtnDebts.Size = new System.Drawing.Size(165, 80);
            this.BtnDebts.TabIndex = 2;
            this.BtnDebts.Text = "Borç işlemleri";
            this.BtnDebts.UseVisualStyleBackColor = true;
            this.BtnDebts.Click += new System.EventHandler(this.BtnDebts_Click);
            // 
            // BtnGraph
            // 
            this.BtnGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGraph.Location = new System.Drawing.Point(179, 237);
            this.BtnGraph.Name = "BtnGraph";
            this.BtnGraph.Size = new System.Drawing.Size(165, 80);
            this.BtnGraph.TabIndex = 3;
            this.BtnGraph.Text = "Muhasebe Raporları";
            this.BtnGraph.UseVisualStyleBackColor = true;
            this.BtnGraph.Click += new System.EventHandler(this.BtnGraph_Click);
            // 
            // BtnSetDues
            // 
            this.BtnSetDues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetDues.Location = new System.Drawing.Point(402, 237);
            this.BtnSetDues.Name = "BtnSetDues";
            this.BtnSetDues.Size = new System.Drawing.Size(165, 80);
            this.BtnSetDues.TabIndex = 4;
            this.BtnSetDues.Text = "Aidat belirleme";
            this.BtnSetDues.UseVisualStyleBackColor = true;
            this.BtnSetDues.Click += new System.EventHandler(this.BtnSetDues_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, -392);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(736, 1308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 486);
            this.Controls.Add(this.BtnSetDues);
            this.Controls.Add(this.BtnGraph);
            this.Controls.Add(this.BtnDebts);
            this.Controls.Add(this.BtnPayDues);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.admin_FormClosing);
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnPayDues;
        private System.Windows.Forms.Button BtnDebts;
        private System.Windows.Forms.Button BtnGraph;
        private System.Windows.Forms.Button BtnSetDues;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}