using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPOO
{
    internal class Date_univ
    {
        String universitate;
        String specializare;
        int an_studiu;

        public Date_univ(string universitate, string specializare, int an_studiu)
        {
            this.universitate = universitate;
            this.specializare = specializare;
            this.an_studiu = an_studiu;
        }

        public string Universitate { get => universitate; set => universitate = value; }
        public string Specializare { get => specializare; set => specializare = value; }
        public int An_studiu { get => an_studiu; set => an_studiu = value; }
    }
}
