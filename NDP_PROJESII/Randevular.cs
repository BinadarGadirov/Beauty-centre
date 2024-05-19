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
        private string dosyaYolu = @"C:\Users\binad\Desktop\SAKIN AÇMA\ndpVERI.txt";
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

        }
    }
}
