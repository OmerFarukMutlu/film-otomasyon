using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Ödev_film_dükkanı_;

namespace lab_odev_2._1
{
    internal class Film_Dukkanı
    {

        private string dosyaYolu = @"C:\Users\faruk\Desktop\filmler.txt";
        public List<Film> FilmleriOku()
        {
            List<Film> filmListesi = new List<Film>();

            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                foreach (string satir in satirlar)
                {
                    string[] parcalar = satir.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                    if (parcalar.Length == 3)
                    {
                        string filmAdi = parcalar[0];
                        string yonetmenAdi = parcalar[1];
                        string kiralama_bedeli = parcalar[2];
                        filmListesi.Add(new Film(filmAdi, yonetmenAdi,kiralama_bedeli));
                    }
                }
            }
            else
            {
                Console.WriteLine("Dosya bulunamadı.");
            }

            return filmListesi;
        }
    }
}
