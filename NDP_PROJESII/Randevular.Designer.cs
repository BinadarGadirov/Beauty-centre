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
            // Randevular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 594);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.randevuGoruntule);
            this.Controls.Add(this.randevuEkle);
            this.Name = "Randevular";
            this.Text = "Randevular";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button randevuEkle;
        private System.Windows.Forms.Button randevuGoruntule;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}