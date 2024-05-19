namespace NDP_PROJESII
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
            this.musteriler = new System.Windows.Forms.Button();
            this.randevular = new System.Windows.Forms.Button();
            this.hizmetler = new System.Windows.Forms.Button();
            this.calisanlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // musteriler
            // 
            this.musteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musteriler.Location = new System.Drawing.Point(558, 266);
            this.musteriler.Name = "musteriler";
            this.musteriler.Size = new System.Drawing.Size(219, 61);
            this.musteriler.TabIndex = 0;
            this.musteriler.Text = "Müşteriler";
            this.musteriler.UseVisualStyleBackColor = true;
            this.musteriler.Click += new System.EventHandler(this.button1_Click);
            // 
            // randevular
            // 
            this.randevular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randevular.Location = new System.Drawing.Point(558, 333);
            this.randevular.Name = "randevular";
            this.randevular.Size = new System.Drawing.Size(219, 61);
            this.randevular.TabIndex = 1;
            this.randevular.Text = "Randevular";
            this.randevular.UseVisualStyleBackColor = true;
            this.randevular.Click += new System.EventHandler(this.button2_Click);
            // 
            // hizmetler
            // 
            this.hizmetler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hizmetler.Location = new System.Drawing.Point(558, 400);
            this.hizmetler.Name = "hizmetler";
            this.hizmetler.Size = new System.Drawing.Size(219, 61);
            this.hizmetler.TabIndex = 2;
            this.hizmetler.Text = "Hizmetler";
            this.hizmetler.UseVisualStyleBackColor = true;
            this.hizmetler.Click += new System.EventHandler(this.button3_Click);
            // 
            // calisanlar
            // 
            this.calisanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calisanlar.Location = new System.Drawing.Point(558, 467);
            this.calisanlar.Name = "calisanlar";
            this.calisanlar.Size = new System.Drawing.Size(219, 61);
            this.calisanlar.TabIndex = 3;
            this.calisanlar.Text = "Çalıışanlar";
            this.calisanlar.UseVisualStyleBackColor = true;
            this.calisanlar.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 712);
            this.Controls.Add(this.calisanlar);
            this.Controls.Add(this.hizmetler);
            this.Controls.Add(this.randevular);
            this.Controls.Add(this.musteriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button musteriler;
        private System.Windows.Forms.Button randevular;
        private System.Windows.Forms.Button hizmetler;
        private System.Windows.Forms.Button calisanlar;
    }
}

