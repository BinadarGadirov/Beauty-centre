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
            string filePath = @"C:\Users\binad\Desktop\SAKIN AÇMA\ndpVERI.txt"; // Gerçek dosya yolunu kullanın
            List<Calisan> calisanlar = ReadEmployee(filePath);
            richTextBox1.Clear();
            foreach (Calisan calisan in calisanlar)
            {
                richTextBox1.AppendText(calisan.ToString() + "\n");
            }
        }
    }
}
