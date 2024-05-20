namespace NDP_PROJESII
{
    partial class Randevular
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
            this.randevuEkle = new System.Windows.Forms.Button();
            this.randevuGoruntule = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtRandevuId = new System.Windows.Forms.TextBox();
            this.txtMusteriId = new System.Windows.Forms.TextBox();
            this.txtServisId = new System.Windows.Forms.TextBox();
            this.txtCalisanId = new System.Windows.Forms.TextBox();
            this.txtRandevuTarihi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kullaniciSilme = new System.Windows.Forms.Button();
            this.SilinecekID = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // randevuEkle
            // 
            this.randevuEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randevuEkle.Location = new System.Drawing.Point(12, 112);
            this.randevuEkle.Name = "randevuEkle";
            this.randevuEkle.Size = new System.Drawing.Size(249, 94);
            this.randevuEkle.TabIndex = 0;
            this.randevuEkle.Text = "Randevu Ekle";
            this.randevuEkle.UseVisualStyleBackColor = true;
            this.randevuEkle.Click += new System.EventHandler(this.randevuEkle_Click);
            // 
            // randevuGoruntule
            // 
            this.randevuGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randevuGoruntule.Location = new System.Drawing.Point(12, 12);
            this.randevuGoruntule.Name = "randevuGoruntule";
            this.randevuGoruntule.Size = new System.Drawing.Size(249, 94);
            this.randevuGoruntule.TabIndex = 1;
            this.randevuGoruntule.Text = "Randevuları Görüntüle";
            this.randevuGoruntule.UseVisualStyleBackColor = true;
            this.randevuGoruntule.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 221);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1062, 361);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // txtRandevuId
            // 
            this.txtRandevuId.Location = new System.Drawing.Point(456, 12);
            this.txtRandevuId.Name = "txtRandevuId";
            this.txtRandevuId.Size = new System.Drawing.Size(49, 22);
            this.txtRandevuId.TabIndex = 4;
            // 
            // txtMusteriId
            // 
            this.txtMusteriId.Location = new System.Drawing.Point(456, 40);
            this.txtMusteriId.Name = "txtMusteriId";
            this.txtMusteriId.Size = new System.Drawing.Size(49, 22);
            this.txtMusteriId.TabIndex = 5;
            // 
            // txtServisId
            // 
            this.txtServisId.Location = new System.Drawing.Point(456, 68);
            this.txtServisId.Name = "txtServisId";
            this.txtServisId.Size = new System.Drawing.Size(49, 22);
            this.txtServisId.TabIndex = 6;
            // 
            // txtCalisanId
            // 
            this.txtCalisanId.Location = new System.Drawing.Point(456, 99);
            this.txtCalisanId.Name = "txtCalisanId";
            this.txtCalisanId.Size = new System.Drawing.Size(49, 22);
            this.txtCalisanId.TabIndex = 7;
            this.txtCalisanId.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtRandevuTarihi
            // 
            this.txtRandevuTarihi.Location = new System.Drawing.Point(456, 130);
            this.txtRandevuTarihi.Name = "txtRandevuTarihi";
            this.txtRandevuTarihi.Size = new System.Drawing.Size(49, 22);
            this.txtRandevuTarihi.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Randevu ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Musteri ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Servis ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Calisan ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Randevu Tarihi";
            // 
            // kullaniciSilme
            // 
            this.kullaniciSilme.Location = new System.Drawing.Point(868, 68);
            this.kullaniciSilme.Name = "kullaniciSilme";
            this.kullaniciSilme.Size = new System.Drawing.Size(75, 23);
            this.kullaniciSilme.TabIndex = 16;
            this.kullaniciSilme.Text = "Sil";
            this.kullaniciSilme.UseVisualStyleBackColor = true;
            this.kullaniciSilme.Click += new System.EventHandler(this.kullaniciSilme_Click);
            // 
            // SilinecekID
            // 
            this.SilinecekID.Location = new System.Drawing.Point(747, 71);
            this.SilinecekID.Name = "SilinecekID";
            this.SilinecekID.Size = new System.Drawing.Size(49, 22);
            this.SilinecekID.TabIndex = 17;
            // 
            // Randevular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 594);
            this.Controls.Add(this.SilinecekID);
            this.Controls.Add(this.kullaniciSilme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRandevuTarihi);
            this.Controls.Add(this.txtCalisanId);
            this.Controls.Add(this.txtServisId);
            this.Controls.Add(this.txtMusteriId);
            this.Controls.Add(this.txtRandevuId);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.randevuGoruntule);
            this.Controls.Add(this.randevuEkle);
            this.Name = "Randevular";
            this.Text = "Randevular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button randevuEkle;
        private System.Windows.Forms.Button randevuGoruntule;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtRandevuId;
        private System.Windows.Forms.TextBox txtMusteriId;
        private System.Windows.Forms.TextBox txtServisId;
        private System.Windows.Forms.TextBox txtCalisanId;
        private System.Windows.Forms.TextBox txtRandevuTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button kullaniciSilme;
        private System.Windows.Forms.TextBox SilinecekID;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}