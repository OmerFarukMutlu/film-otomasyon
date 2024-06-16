using lab_odev_2._1;

namespace Ödev_film_dükkanı_
{
    public partial class Form1 : Form
    {
        Kiralanan_film kiralama;
        private List<Film> filmler;
        string secilenFilmAdi;
        string secilenYonetmen;
        string secilenfilmbedeli;
        public Form1()
        {

            InitializeComponent();
            Film_Dukkanı filmDukkanı = new Film_Dukkanı();
            filmler = filmDukkanı.FilmleriOku();
            foreach (var film in filmler)
            {
                comboBox1.Items.Add(film.film_ismi);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (var film in filmler)
            {
                dataGridView1.Rows.Add(film.film_ismi, film.yönetmen, film.kiralama_bedeli);
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            secilenFilmAdi = comboBox1.SelectedItem.ToString();
            secilenYonetmen = "";
            secilenfilmbedeli = "";
            foreach (var film in filmler)
            {
                if (film.film_ismi == secilenFilmAdi)
                {
                    secilenYonetmen = film.yönetmen;
                    secilenfilmbedeli = film.kiralama_bedeli;
                    break;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double bedel = Convert.ToDouble(textBox4.Text) * Convert.ToDouble(secilenfilmbedeli);

            String text = secilenFilmAdi + ", " + secilenYonetmen + ", " + secilenfilmbedeli + ", " + textBox1.Text + ", " + textBox2.Text + ", " + textBox3.Text + ", " + textBox4.Text + ", " + bedel;
            using (StreamWriter sw = new StreamWriter(@"C:\Users\faruk\Desktop\kiralanan film.txt", true))
            {
                sw.WriteLine(text);
            }
            label5.Text = "Ödenecek Ücret:" + Convert.ToString(bedel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();


            form2.YukleData();


            form2.Show();


            this.Hide();
        }
    }
}
