using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_film_dükkanı_
{
    internal class Film
    {
        public string film_ismi;
        public string yönetmen;
        public string kiralama_bedeli;
        public Film(string film_ismi, string yönetmen, string kiralama_bedeli)
        {
            this.film_ismi = film_ismi;
            this.yönetmen = yönetmen;
            this.kiralama_bedeli = kiralama_bedeli;
        }
    }
}
