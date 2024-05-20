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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NDP_PROJESII.Hizmetler;

namespace NDP_PROJESII
{

    public partial class Hizmetler : Form
    {
        public Hizmetler()
        {
            InitializeComponent();
        }
        public class Service
        {
            public int Id { get; set; }
            public string ServiceName { get; set; }
            public double ServicePrice { get; set; }
            public Service(int id, string serviceName, double servicePrice)
            {
                Id = id;
                ServiceName = serviceName;
                ServicePrice = servicePrice;

            }
            public override string ToString()
            {
                return $"ID: {Id}, İsim: {ServiceName}, Fiyat : {ServicePrice.ToString()}";
            }
        }
        private List<Service> ReadServices(string filePath)
        {
            List<Service> services = new List<Service>();
            bool startReading = false;
            foreach (var line in File.ReadAllLines(filePath))
            {
                if (line.Trim() == "Hizmetler:")
                {
                    startReading = true;
                    continue;
                }
                if (startReading && !string.IsNullOrWhiteSpace(line))
                {
                    var parts = line.Split('-');
                    services.Add(new Service(
                        int.Parse(parts[0]),
                        parts[1],
                        double.Parse(parts[2])
                    ));
                }
            }
            return services;
        }


        private void Hizmetler_Load(object sender, EventArgs e)
        {

        }

        private void hizmetGoruntule_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\binad\source\repos\NDP_PROJESII\Veriler\Hizmet.txt"; // Gerçek dosya yolunu kullanın
            List<Service> services = ReadServices(filePath);
            richTextBox1.Clear();
            foreach (Service service in services)
            {
                richTextBox1.AppendText(service.ToString() + "\n");
            }
        }
        private void AddService(string filePath, Service service)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                string serviceLine = $"{service.Id}-{service.ServiceName}-{service.ServicePrice}";
                sw.WriteLine(serviceLine);
            }
        }


        private void hizmetEkle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(hizmetID.Text);
            string name = hizmetIsmi.Text;
            double price = double.Parse(hizmetFiyati.Text);

            Service newService = new Service(id, name, price);
            string filePath = @"C:\Users\binad\source\repos\NDP_PROJESII\Veriler\Hizmet.txt"; // Gerçek dosya yolunu kullanın
            AddService(filePath, newService);

            MessageBox.Show("Service successfully added.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dosyaYolu = @"C:\Users\binad\source\repos\NDP_PROJESII\Veriler\Hizmet.txt"; // Dosya yolunu buraya ekleyin
            string silinecekIdStr = SilinecekID.Text.Trim();

            if (!int.TryParse(silinecekIdStr, out int silinecekId))
            {
                MessageBox.Show("Lütfen geçerli bir ID girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                List<string> satirlar = File.ReadAllLines(dosyaYolu).ToList();
                bool isHizmetlerSection = false;
                bool silindi = false;

                for (int i = 0; i < satirlar.Count; i++)
                {
                    string satir = satirlar[i];
                    if (satir.StartsWith("Hizmetler:"))
                    {
                        isHizmetlerSection = true;
                        continue;
                    }

                    if (isHizmetlerSection && !string.IsNullOrWhiteSpace(satir))
                    {
                        string[] veri = satir.Split('-');
                        if (veri.Length > 0 && int.TryParse(veri[0].Trim(), out int id) && id == silinecekId)
                        {
                            satirlar.RemoveAt(i);
                            silindi = true;
                            break;
                        }
                    }

                    if (string.IsNullOrWhiteSpace(satir) && isHizmetlerSection)
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
