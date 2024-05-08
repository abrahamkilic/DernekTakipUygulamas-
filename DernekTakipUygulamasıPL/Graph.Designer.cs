namespace DernekTakipUygulamasıPL
{
    partial class Graph
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graph));
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.BtnYear = new System.Windows.Forms.Button();
            this.comboBoxYears = new System.Windows.Forms.ComboBox();
            this.BtnAylik = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 238);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(939, 445);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // BtnYear
            // 
            this.BtnYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYear.Location = new System.Drawing.Point(12, 12);
            this.BtnYear.Name = "BtnYear";
            this.BtnYear.Size = new System.Drawing.Size(184, 85);
            this.BtnYear.TabIndex = 2;
            this.BtnYear.Text = "Yıllık";
            this.BtnYear.UseVisualStyleBackColor = true;
            this.BtnYear.Click += new System.EventHandler(this.BtnYear_Click);
            // 
            // comboBoxYears
            // 
            this.comboBoxYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxYears.FormattingEnabled = true;
            this.comboBoxYears.Location = new System.Drawing.Point(12, 194);
            this.comboBoxYears.Name = "comboBoxYears";
            this.comboBoxYears.Size = new System.Drawing.Size(184, 28);
            this.comboBoxYears.TabIndex = 3;
            this.comboBoxYears.SelectedIndexChanged += new System.EventHandler(this.comboBoxYears_SelectedIndexChanged);
            // 
            // BtnAylik
            // 
            this.BtnAylik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAylik.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAylik.Location = new System.Drawing.Point(12, 103);
            this.BtnAylik.Name = "BtnAylik";
            this.BtnAylik.Size = new System.Drawing.Size(184, 85);
            this.BtnAylik.TabIndex = 4;
            this.BtnAylik.Text = "Aylık";
            this.BtnAylik.UseVisualStyleBackColor = true;
            this.BtnAylik.Click += new System.EventHandler(this.BtnAylik_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(230, -37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 259);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(762, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 94);
            this.button1.TabIndex = 6;
            this.button1.Text = "Şehir Grafiği";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(973, 707);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAylik);
            this.Controls.Add(this.comboBoxYears);
            this.Controls.Add(this.BtnYear);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Graph";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.Graph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button BtnYear;
        private System.Windows.Forms.ComboBox comboBoxYears;
        private System.Windows.Forms.Button BtnAylik;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}