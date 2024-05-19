using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_PROJESII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = @"Server=your_server_name; Database=GüzellikMerkezi; Trusted_Connection=True;";

        private void button2_Click(object sender, EventArgs e)
        {


            Randevular randevuForm = new Randevular();  // RandevuFormu'un bir örneğini oluşturuyoruz
            randevuForm.Show();  // RandevuFormu'u gösteriyoruz
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteriler musteriForm = new Musteriler();  // MusteriForm'un bir örneğini oluşturuyoruz
            musteriForm.Show();  // MusteriForm'u gösteriyoruz
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hizmetler hizmetlerForm = new Hizmetler();  // hizmetlerForm'un bir örneğini oluşturuyoruz
            hizmetlerForm.Show();  // hizmetlerForm'u gösteriyoruz
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calisanlar calisanlarForm = new Calisanlar();  // calisanlarForm'un bir örneğini oluşturuyoruz
            calisanlarForm.Show();  // calisanlarForm'u gösteriyoruz
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
