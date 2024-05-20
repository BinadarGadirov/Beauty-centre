namespace NDP_PROJESII
{
    partial class Hizmetler
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
            this.hizmetEkle = new System.Windows.Forms.Button();
            this.hizmetGoruntule = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hizmetID = new System.Windows.Forms.TextBox();
            this.hizmetIsmi = new System.Windows.Forms.TextBox();
            this.hizmetFiyati = new System.Windows.Forms.TextBox();
            this.SilinecekID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // hizmetEkle
            // 
            this.hizmetEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hizmetEkle.Location = new System.Drawing.Point(481, 12);
            this.hizmetEkle.Name = "hizmetEkle";
            this.hizmetEkle.Size = new System.Drawing.Size(224, 96);
            this.hizmetEkle.TabIndex = 0;
            this.hizmetEkle.Text = "Hizmet Ekle";
            this.hizmetEkle.UseVisualStyleBackColor = true;
            this.hizmetEkle.Click += new System.EventHandler(this.hizmetEkle_Click);
            // 
            // hizmetGoruntule
            // 
            this.hizmetGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hizmetGoruntule.Location = new System.Drawing.Point(12, 12);
            this.hizmetGoruntule.Name = "hizmetGoruntule";
            this.hizmetGoruntule.Size = new System.Drawing.Size(224, 96);
            this.hizmetGoruntule.TabIndex = 1;
            this.hizmetGoruntule.Text = "Hizmetleri Görüntüle";
            this.hizmetGoruntule.UseVisualStyleBackColor = true;
            this.hizmetGoruntule.Click += new System.EventHandler(this.hizmetGoruntule_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 216);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(872, 276);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hizmet IDsi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hizmet Ismi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hizmet Fiyatı";
            // 
            // hizmetID
            // 
            this.hizmetID.Location = new System.Drawing.Point(375, 21);
            this.hizmetID.Name = "hizmetID";
            this.hizmetID.Size = new System.Drawing.Size(100, 22);
            this.hizmetID.TabIndex = 7;
            // 
            // hizmetIsmi
            // 
            this.hizmetIsmi.Location = new System.Drawing.Point(375, 54);
            this.hizmetIsmi.Name = "hizmetIsmi";
            this.hizmetIsmi.Size = new System.Drawing.Size(100, 22);
            this.hizmetIsmi.TabIndex = 8;
            // 
            // hizmetFiyati
            // 
            this.hizmetFiyati.Location = new System.Drawing.Point(375, 82);
            this.hizmetFiyati.Name = "hizmetFiyati";
            this.hizmetFiyati.Size = new System.Drawing.Size(100, 22);
            this.hizmetFiyati.TabIndex = 9;
            // 
            // SilinecekID
            // 
            this.SilinecekID.Location = new System.Drawing.Point(617, 167);
            this.SilinecekID.Name = "SilinecekID";
            this.SilinecekID.Size = new System.Drawing.Size(88, 22);
            this.SilinecekID.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Silinecek ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(711, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hizmetler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SilinecekID);
            this.Controls.Add(this.hizmetFiyati);
            this.Controls.Add(this.hizmetIsmi);
            this.Controls.Add(this.hizmetID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.hizmetGoruntule);
            this.Controls.Add(this.hizmetEkle);
            this.Name = "Hizmetler";
            this.Text = "Hizmetler";
            this.Load += new System.EventHandler(this.Hizmetler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hizmetEkle;
        private System.Windows.Forms.Button hizmetGoruntule;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hizmetID;
        private System.Windows.Forms.TextBox hizmetIsmi;
        private System.Windows.Forms.TextBox hizmetFiyati;
        private System.Windows.Forms.TextBox SilinecekID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}