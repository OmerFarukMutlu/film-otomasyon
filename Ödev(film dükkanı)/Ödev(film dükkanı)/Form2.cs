using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev_film_dükkanı_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void YukleData()
        {
            
            string dosyaYolu = @"C:\Users\faruk\Desktop\kiralanan film.txt";
            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);
                foreach (string satir in satirlar)
                {
                    string[] parcalar = satir.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                    if (parcalar.Length == 8)
                    {
                        dataGridView1.Rows.Add(parcalar);
                    }
                }
            }
            else
            {
                MessageBox.Show("Dosya bulunamadı.");
            }
        }
    }
}

