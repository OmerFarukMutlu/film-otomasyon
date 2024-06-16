using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_film_dükkanı_
{
    internal class Kişi
    {
        private string isim;
        private string soyisim;
        private string telefon_numarası;
       
        public Kişi(string isim, string soyisim, string telefon_numarası)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.telefon_numarası = telefon_numarası;
            
        }
    }
}
