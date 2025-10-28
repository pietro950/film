using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film
{
    internal class Film
    {
         public int ID_Film { get; set; }
        public String Titolo { get; set; }
        public String Regista { get; set; }
        public int durata { get; set; }

        public bool Tipo { get; set; }  //true per dvd, false per Blu Ray
        public bool Noleggio { get; set; }
        public static int IDFilm= 0;

        public Film()
        {
         
        }
        public Film(int pID_Film, String pTitolo, string pregista, int pdurata, bool ptipo, bool pnoleggio)
        {
          this.ID_Film = pID_Film;
            this.Titolo = pTitolo;
            this.Regista = pregista;
            this.durata = pdurata;
            this.Tipo = ptipo;
            this.Noleggio = pnoleggio;
            IDFilm++;   
        }

    }
}
