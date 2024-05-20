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
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_PROJESII
{
    public partial class Randevular : Form
    {
        private string dosyaYolu = @"C:\Users\binad\source\repos\NDP_PROJESII\Veriler\Randevular.txt";
        public Randevular()
        {
            InitializeComponent();
        }
        public class Randevu
        {
            public int RandevuId { get; set; }
            public int MusteriId { get; set; }
            public int ServisId { get; set; }
            public int CalisanId { get; set; }
            public DateTime RandevuTarihi { get; set; }

            public Randevu(int randevuId, int musteriId, int servisId, int calisanId, DateTime randevuTarihi)
            {
                RandevuId = randevuId;
                MusteriId = musteriId;
                ServisId = servisId;
                CalisanId = calisanId;
                RandevuTarihi = randevuTarihi;
            }

            public override string ToString()
            {
                return $"Randevu ID: {RandevuId}, Musteri ID: {MusteriId}, Servis ID: {ServisId}, Calisan ID: {CalisanId}, Randevu Tarihi: {RandevuTarihi}";
            }
        }
        private List<Randevu> RandevulariOku(string dosyaYolu)
        {
            List<Randevu> randevular = new List<Randevu>();
            string[] satirlar = File.ReadAllLines(dosyaYolu);
            bool isRandevularSection = false;
            string[] formats = { "dd/MM/yyyy HH", "MM/dd/yyyy HH", "yyyy-MM-dd HH" };

            foreach (string satir in satirlar)
            {
                if (satir.StartsWith("Randevular:"))
                {
                    isRandevularSection = true;
                    continue; // "Randevular:" satırını atla
                }

                if (isRandevularSection && !string.IsNullOrWhiteSpace(satir))
                {
                    string[] veri = satir.Split('-');
                    if (veri.Length == 5)
                    {
                        try
                        {
                            int randevuId = int.Parse(veri[0].Trim());
                            int musteriId = int.Parse(veri[1].Trim());
                            int servisId = int.Parse(veri[2].Trim());
                            int calisanId = int.Parse(veri[3].Trim());
                            DateTime randevuTarihi;

                            if (DateTime.TryParseExact(veri[4].Trim(), formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out randevuTarihi))
                            {
                                Randevu randevu = new Randevu(randevuId, musteriId, servisId, calisanId, randevuTarihi);
                                randevular.Add(randevu);
                            }
                            else
                            {
                                throw new FormatException("Tarih formatı geçersiz.");
                            }
                        }
                        catch (Exception ex)
                        {
                            // Hatalı satırı veya hatayı loglama
                            Console.WriteLine($"Hatalı veri satırı: {satir}, Hata: {ex.Message}");
                        }
                    }
                }
            }

            return randevular;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            List<Randevu> randevular = RandevulariOku(dosyaYolu);
            richTextBox1.Clear();
            foreach (Randevu randevu in randevular)
            {
                richTextBox1.AppendText(randevu.ToString() + "\n");
            }
        }

        private void randevuEkle_Click(object sender, EventArgs e)
        {
            int randevuId = int.Parse(txtRandevuId.Text);
            int musteriId = int.Parse(txtMusteriId.Text);
            int servisId = int.Parse(txtServisId.Text);
            int calisanId = int.Parse(txtCalisanId.Text);
            DateTime randevuTarihi = DateTime.ParseExact(txtRandevuTarihi.Text, "dd/MM/yyyy HH", CultureInfo.InvariantCulture);

            Randevu yeniRandevu = new Randevu(randevuId, musteriId, servisId, calisanId, randevuTarihi);
            string dosyaYolu = @"C:\Users\binad\source\repos\NDP_PROJESII\Veriler\Randevular.txt"; // Dosya yolu örnektir, gerçek yolu kullanın.
            RandevuEkle(dosyaYolu, yeniRandevu);

            MessageBox.Show("Randevu başarıyla eklendi.");
            button2_Click(sender, e);
        }
        private void RandevuEkle(string dosyaYolu, Randevu randevu)
        {
            using (StreamWriter sw = File.AppendText(dosyaYolu))
            {
                string randevuSatiri = $"{randevu.RandevuId}-{randevu.MusteriId}-{randevu.ServisId}-{randevu.CalisanId}-{randevu.RandevuTarihi:dd/MM/yyyy HH}";
                sw.WriteLine(randevuSatiri);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void kullaniciSilme_Click(object sender, EventArgs e)
        {
            string dosyaYolu = @"C:\Users\binad\source\repos\NDP_PROJESII\Veriler\Randevular.txt"; // Dosya yolunu buraya ekleyin
            string silinecekIdStr = SilinecekID.Text.Trim();

            if (!int.TryParse(silinecekIdStr, out int silinecekId))
            {
                MessageBox.Show("Lütfen geçerli bir Randevu ID girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                List<string> satirlar = File.ReadAllLines(dosyaYolu).ToList();
                bool silindi = false;

                for (int i = 0; i < satirlar.Count; i++)
                {
                    string[] veri = satirlar[i].Split('-');
                    if (veri.Length > 0 && int.TryParse(veri[0].Trim(), out int randevuId) && randevuId == silinecekId)
                    {
                        satirlar.RemoveAt(i);
                        silindi = true;
                        break;
                    }
                }

                if (silindi)
                {
                    File.WriteAllLines(dosyaYolu, satirlar);
                    MessageBox.Show("Randevu ID başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Girilen Randevu ID bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
