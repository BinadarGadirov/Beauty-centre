namespace NDP_PROJESII
{
    partial class Calisanlar
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
            this.calisanEkle = new System.Windows.Forms.Button();
            this.calisanGoruntule = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // calisanEkle
            // 
            this.calisanEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calisanEkle.Location = new System.Drawing.Point(12, 127);
            this.calisanEkle.Name = "calisanEkle";
            this.calisanEkle.Size = new System.Drawing.Size(232, 109);
            this.calisanEkle.TabIndex = 0;
            this.calisanEkle.Text = "Çalışan Ekle";
            this.calisanEkle.UseVisualStyleBackColor = true;
            // 
            // calisanGoruntule
            // 
            this.calisanGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calisanGoruntule.Location = new System.Drawing.Point(12, 12);
            this.calisanGoruntule.Name = "calisanGoruntule";
            this.calisanGoruntule.Size = new System.Drawing.Size(232, 109);
            this.calisanGoruntule.TabIndex = 1;
            this.calisanGoruntule.Text = "Çalışanları Görüntüle";
            this.calisanGoruntule.UseVisualStyleBackColor = true;
            this.calisanGoruntule.Click += new System.EventHandler(this.calisanGoruntule_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 242);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(644, 281);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Calisanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 733);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.calisanGoruntule);
            this.Controls.Add(this.calisanEkle);
            this.Name = "Calisanlar";
            this.Text = "Calisanlar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calisanEkle;
        private System.Windows.Forms.Button calisanGoruntule;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}