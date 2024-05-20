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
using static NDP_PROJESII.Hizmetler;

namespace NDP_PROJESII
{
    public partial class Calisanlar : Form
    {
        public Calisanlar()
        {
            InitializeComponent();
        }
        
        public class Calisan 
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string SurName { get; set; }
            public string Position { get; set; }

            public Calisan(int id, string firstName, string surName, string position)
            {
                Id = id;
                FirstName = firstName;
                SurName = surName;
                Position = position;
            }
            public override string ToString()
            {
                return $"ID: {Id}, İsim: {FirstName}, SoyIsim : {SurName}, Pozisyon : {Position}";
            }
        }
        private List<Calisan> ReadEmployee(string filePath)
        {
            List<Calisan> calisanlar = new List<Calisan>();
            string[] satirlar = File.ReadAllLines(filePath);
            bool isCalisanlarSection = false;

            foreach (string satir in satirlar)
            {
                if (satir.StartsWith("Çalışanlar:"))
                {
                    isCalisanlarSection = true;
                    continue; // "Çalışanlar:" satırını atla
                }

                if (isCalisanlarSection && !string.IsNullOrWhiteSpace(satir))
                {
                    string[] veri = satir.Split('-');
                    if (veri.Length == 4)
                    {
                        try
                        {
                            int id = int.Parse(veri[0]);
                            string isim = veri[1].Trim();
                            string soyisim = veri[2].Trim();
                            string departman = veri[3].Trim();

                            Calisan calisan = new Calisan(id, isim, soyisim, departman);
                            calisanlar.Add(calisan);
                        }
                        catch (Exception ex)
                        {
                            // Hatalı satırı veya hatayı loglama
                            Console.WriteLine($"Hatalı veri satırı: {satir}, Hata: {ex.Message}");
                        }
                    }
                }
            }

            return calisanlar;
        }

        private void calisanGoruntule_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\binad\source\repos\NDP_PROJESII\Veriler\Calisan.txt"; // Gerçek dosya yolunu kullanın
            List<Calisan> calisanlar = ReadEmployee(filePath);
            richTextBox1.Clear();
            foreach (Calisan calisan in calisanlar)
            {
                richTextBox1.AppendText(calisan.ToString() + "\n");
            }
        }
        private void CalisanEkle(string dosyaYolu, Calisan calisan)
        {
            using (StreamWriter sw = File.AppendText(dosyaYolu))
            {
                string calisanSatiri = $"{calisan.Id}-{calisan.FirstName}-{calisan.SurName}-{calisan.Position}";
                sw.WriteLine(calisanSatiri);
            }
        }

        private void calisanEkle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCalisanId.Text);
            string isim = txtCalisanIsim.Text;
            string soyisim = txtCalisanSoyisim.Text;
            string pozisyon = txtPozisyon.Text;

            Calisan yeniCalisan = new Calisan(id,isim,soyisim,pozisyon);
            string dosyaYolu = @"C:\Users\binad\source\repos\NDP_PROJESII\Veriler\Calisan.txt"; // Dosya yolu örnektir, gerçek yolu kullanın.
            CalisanEkle(dosyaYolu,yeniCalisan);

            MessageBox.Show("Çalışan başarıyla eklendi.");
        }

        private void Calisanlar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dosyaYolu = @"C:\Users\binad\source\repos\NDP_PROJESII\Veriler\Calisan.txt"; // Dosya yolunu buraya ekleyin
            string silinecekIdStr = SilinecekID.Text.Trim();

            if (!int.TryParse(silinecekIdStr, out int silinecekId))
            {
                MessageBox.Show("Lütfen geçerli bir ID girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                List<string> satirlar = File.ReadAllLines(dosyaYolu).ToList();
                bool isCalisanlarSection = false;
                bool silindi = false;

                for (int i = 0; i < satirlar.Count; i++)
                {
                    string satir = satirlar[i];
                    if (satir.StartsWith("Çalışanlar:"))
                    {
                        isCalisanlarSection = true;
                        continue;
                    }

                    if (isCalisanlarSection && !string.IsNullOrWhiteSpace(satir))
                    {
                        string[] veri = satir.Split('-');
                        if (veri.Length > 0 && int.TryParse(veri[0].Trim(), out int id) && id == silinecekId)
                        {
                            satirlar.RemoveAt(i);
                            silindi = true;
                            break;
                        }
                    }

                    if (string.IsNullOrWhiteSpace(satir) && isCalisanlarSection)
                    {
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
    }
}
