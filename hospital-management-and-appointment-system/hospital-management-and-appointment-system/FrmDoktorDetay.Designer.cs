namespace hospital_management_and_appointment_system
{
    partial class FrmDoktorDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.RchSikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnDuyurular = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnInternet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LblAdSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(128, 83);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(85, 23);
            this.LblAdSoyad.TabIndex = 1;
            this.LblAdSoyad.Text = "Null Null";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(128, 50);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(120, 23);
            this.LblTC.TabIndex = 3;
            this.LblTC.Text = "00000000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "TC NO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RchSikayet);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 354);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(332, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(695, 638);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 607);
            this.dataGridView1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şikayet:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // RchSikayet
            // 
            this.RchSikayet.Location = new System.Drawing.Point(6, 64);
            this.RchSikayet.Name = "RchSikayet";
            this.RchSikayet.Size = new System.Drawing.Size(288, 284);
            this.RchSikayet.TabIndex = 1;
            this.RchSikayet.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnCikis);
            this.groupBox4.Controls.Add(this.BtnInternet);
            this.groupBox4.Controls.Add(this.BtnDuyurular);
            this.groupBox4.Controls.Add(this.BtnGüncelle);
            this.groupBox4.Location = new System.Drawing.Point(13, 543);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 108);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGüncelle.Location = new System.Drawing.Point(10, 28);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(141, 29);
            this.BtnGüncelle.TabIndex = 0;
            this.BtnGüncelle.Text = "Bilgi Düzenle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            // 
            // BtnDuyurular
            // 
            this.BtnDuyurular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDuyurular.Location = new System.Drawing.Point(153, 28);
            this.BtnDuyurular.Name = "BtnDuyurular";
            this.BtnDuyurular.Size = new System.Drawing.Size(141, 29);
            this.BtnDuyurular.TabIndex = 1;
            this.BtnDuyurular.Text = "Duyurular";
            this.BtnDuyurular.UseVisualStyleBackColor = true;
            // 
            // BtnCikis
            // 
            this.BtnCikis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCikis.Location = new System.Drawing.Point(153, 66);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(141, 29);
            this.BtnCikis.TabIndex = 3;
            this.BtnCikis.Text = "Cıkıs";
            this.BtnCikis.UseVisualStyleBackColor = true;
            // 
            // BtnInternet
            // 
            this.BtnInternet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnInternet.Location = new System.Drawing.Point(10, 66);
            this.BtnInternet.Name = "BtnInternet";
            this.BtnInternet.Size = new System.Drawing.Size(141, 29);
            this.BtnInternet.TabIndex = 2;
            this.BtnInternet.Text = "Internet";
            this.BtnInternet.UseVisualStyleBackColor = true;
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1048, 673);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmDoktorDetay";
            this.Text = "FrmDoktorDetay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox RchSikayet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnInternet;
        private System.Windows.Forms.Button BtnDuyurular;
        private System.Windows.Forms.Button BtnGüncelle;
    }
}