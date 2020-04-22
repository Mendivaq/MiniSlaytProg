using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace yilanoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] dosyalar = Directory.GetFiles(@"C:\Users\ekkoe\OneDrive\Masaüstü\Projelerim\Slaytislemi\bin\Debug\Resimler", "*.jpg");
        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Interval = 2000;
        }
        
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png;*.mp3| Video|*.avi| Tüm Dosyalar |*.*";
            dosya.Title = "Emirhan Coşkun";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            pictureBox1.ImageLocation = DosyaYolu;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            pictureBox2.ImageLocation = dosyalar[r.Next(0, dosyalar.Length)];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            pictureBox2.ImageLocation = dosyalar[r.Next(0, dosyalar.Length)];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult dialog2 = new DialogResult();
            dialog2 = MessageBox.Show("Slayt gösterisi kapatılıyor.", "Tamam", MessageBoxButtons.OKCancel);
            if (DialogResult == DialogResult.Cancel)
            {
                this.Close();

            }
            else
            {
                MessageBox.Show("Çıkış yapılmadı");
            }   



        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Slayt gösterisi başlıyor", "Tamam", MessageBoxButtons.OK);
            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
