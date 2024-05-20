                                 /****************************************************************************
                                 **					SAKARYA ÜNİVERSİTESİ
                                 **				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
                                 **				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
                                 **				   NESNEYE DAYALI PROGRAMLAMA DERSİ
                                 **					2023-2024 BAHAR DÖNEMİ
                                 **	
                                 **				ÖDEV NUMARASI..........: Proje 1
                                 **				ÖĞRENCİ ADI............: Binadar Gadirov
                                 **				ÖĞRENCİ NUMARASI.......: B221210561
                                 **                         DERSİN ALINDIĞI GRUP...: 1.B
                                 ****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_PROJESII

{
    
    public partial class Musteriler : Form
    {
        private string dosyaYolu = @"C:\Users\binad\source\repos\NDP_PROJESII\Veriler\Musteri.txt";

        public Musteriler()
        {
            InitializeComponent();
        }
        
        public class Musteri 
        {
            public int Id { get; set; }
            public string Isim { get; set; }
            public string Soyisim { get; set; }
            public string Telefon { get; set; }
            public string Eposta { get; set; }

            public Musteri(int id, string isim, string soyisim, string telefon, string eposta)
            {
                Id = id;
                Isim = isim;
                Soyisim = soyisim;
                Telefon = telefon;
                Eposta = eposta;
            }

            public override string ToString()
            {
                return $"ID: {Id}, İsim: {Isim}, Soyisim: {Soyisim}, Telefon: {Telefon}, Email : {Eposta}";
            }

            internal string ToFileString()
            {
                throw new NotImplementedException();
            }
        }
        private List<Musteri> MusterileriOku(string dosyaYolu)
        {
            List<Musteri> musteriler = new List<Musteri>();
            string[] satirlar = File.ReadAllLines(dosyaYolu);
            bool isMusterilerSection = false;

            foreach (string satir in satirlar)
            {
                if (satir.StartsWith("Müşteriler:"))
                {
                    isMusterilerSection = true;
                    continue; // "Musteriler:" satırını atla
                }
                else if (satir.StartsWith(" "))
                {
                    isMusterilerSection = false;
                    break;
                }

                if (isMusterilerSection && !string.IsNullOrWhiteSpace(satir))
                {
                    string[] veri = satir.Split('-');
                    if (veri.Length == 5)
                    {
                        try
                        {
                            int id = int.Parse(veri[0].Trim());
                            string isim = veri[1].Trim();
                            string soyisim = veri[2].Trim();
                            string email = veri[3].Trim();
                            string telefon = veri[4].Trim();

                            Musteri musteri = new Musteri(id, isim, soyisim, email, telefon);
                            musteriler.Add(musteri);
                        }
                        catch (Exception ex)
                        {
                            // Hatalı satırı veya hatayı loglama
                            Console.WriteLine($"Hatalı veri satırı: {satir}, Hata: {ex.Message}");
                        }
                    }
                }
            }

            return musteriler;

        }
        private void musteriGoruntule_Click(object sender, EventArgs e)
        {
            List<Musteri> musteriler = MusterileriOku(dosyaYolu);
            richTextBox1.Clear();
            foreach (Musteri musteri in musteriler)
            {
                richTextBox1.AppendText(musteri.ToString() + "\n");
            }

        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
        }
        private void MusteriEkle(string dosyaYolu, Musteri musteri)
        {
            using (StreamWriter sw = File.AppendText(dosyaYolu))
            {
                string musteriSatiri = $"{musteri.Id}-{musteri.Isim}-{musteri.Soyisim}-{musteri.Telefon}-{musteri.Eposta}";
                sw.WriteLine(musteriSatiri);
            }
        }

        private void musteriEkle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string isim = txtIsim.Text;
            string soyisim = txtSoyisim.Text;
            string telefon = txtTelefon.Text;
            string eposta = txtEposta.Text;

            Musteri yeniMusteri = new Musteri(id, isim, soyisim, telefon, eposta);
            string dosyaYolu = @"C:\Users\binad\source\repos\NDP_PROJESII\Veriler\Musteri.txt"; // Dosya yolu örnektir, gerçek yolu kullanın.
            MusteriEkle(dosyaYolu, yeniMusteri);

            MessageBox.Show("Müşteri başarıyla eklendi.");
        }
        private void kullaniciSilme_Click_1(object sender, EventArgs e)
        {

            string dosyaYolu = @"C:\Users\binad\source\repos\NDP_PROJESII\Veriler\Musteri.txt"; // Dosya yolunu buraya ekleyin
            string silinecekIdStr = SilinecekID.Text.Trim();

            if (!int.TryParse(silinecekIdStr, out int silinecekId))
            {
                MessageBox.Show("Lütfen geçerli bir ID girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                List<string> satirlar = File.ReadAllLines(dosyaYolu).ToList();
                bool silindi = false;

                for (int i = 0; i < satirlar.Count; i++)
                {
                    string[] veri = satirlar[i].Split('-');
                    if (veri.Length > 0 && int.TryParse(veri[0].Trim(), out int id) && id == silinecekId)
                    {
                        satirlar.RemoveAt(i);
                        silindi = true;
                        break;
                    }
                }

                if (silindi)
                {
                    File.WriteAllLines(dosyaYolu, satirlar);
                    MessageBox.Show("ID başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Girilen ID bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DosyaKaydet();
        }
        public void DosyaKaydet()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Txt olarak kaydetme";
            saveFileDialog1.FileName = "Isim belirleyiniz";
            saveFileDialog1.Filter = "Metin dosyası(*.txt)|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<string> satirlar = File.ReadAllLines(dosyaYolu).ToList();
                    List<string> yeniSatirlar = new List<string>();
                    bool isMusterilerSection = false;

                    foreach (string satir in satirlar)
                    {
                        if (satir.StartsWith("Müşteriler:"))
                        {
                            isMusterilerSection = true;
                            yeniSatirlar.Add(satir);
                            continue;
                        }

                        if (isMusterilerSection)
                        {
                            if (string.IsNullOrWhiteSpace(satir))
                            {
                                isMusterilerSection = false;
                            }
                            else
                            {
                                // Müşteriler bölümünü atla
                                continue;
                            }
                        }

                        yeniSatirlar.Add(satir);
                    }

                    // RichTextBox'taki verileri dosya formatına çevirerek ekleyin
                    string[] richTextBoxSatirlar = richTextBox1.Text.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string richTextBoxSatiri in richTextBoxSatirlar)
                    {
                        if (richTextBoxSatiri.StartsWith("Müşteriler:"))
                        {
                            if (richTextBoxSatiri.StartsWith("ID:"))
                            {
                                string[] veri = richTextBoxSatiri.Split(new[] { ", " }, StringSplitOptions.None);
                                int id = int.Parse(veri[0].Split(new[] { ": " }, StringSplitOptions.None)[1].Trim());
                                string isim = veri[1].Split(new[] { ": " }, StringSplitOptions.None)[1].Trim();
                                string soyisim = veri[2].Split(new[] { ": " }, StringSplitOptions.None)[1].Trim();
                                string telefon = veri[3].Split(new[] { ": " }, StringSplitOptions.None)[1].Trim();
                                string email = veri[4].Split(new[] { ": " }, StringSplitOptions.None)[1].Trim();

                                Musteri musteri = new Musteri(id, isim, soyisim, telefon, email);
                                yeniSatirlar.Add(musteri.ToFileString());
                            }
                        }
                    }

                    File.WriteAllLines(saveFileDialog1.FileName, yeniSatirlar);

                    MessageBox.Show("Kayıt tamamlandı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
