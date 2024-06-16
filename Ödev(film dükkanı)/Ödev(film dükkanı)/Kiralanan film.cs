using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_film_dükkanı_
{
    internal class Kiralanan_film
    {
        private Kişi müsteri;
        private Film kiralananfilm;
        private double kiralama_süresi;

        public Kiralanan_film(Kişi müsteri, Film kiralananfilm, double kiralama_süresi)
        {
            this.müsteri = müsteri;
            this.kiralananfilm = kiralananfilm;
            this.kiralama_süresi = kiralama_süresi;

        }
       
    }
}
