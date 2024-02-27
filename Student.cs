using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPOO
{
    internal class Student
    {
        String nume;
        String adresa;
        int an_nastere;
        Date_univ date_univ;

        public Student(string nume, string adresa, int an_nastere, Date_univ date_univ)
        {
            this.nume = nume;
            this.adresa = adresa;
            this.an_nastere = an_nastere;
            this.date_univ = date_univ;
        }

        public string Nume { get => nume; set => nume = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public int An_nastere { get => an_nastere; set => an_nastere = value; }
        internal Date_univ Date_univ { get => date_univ; set => date_univ = value; }


        public void displayStudent()
        {
            Console.WriteLine(this.nume + " " + this.adresa + " " + this.an_nastere + " " + this.date_univ.Universitate + " " + this.date_univ.Specializare + " " + this.date_univ.An_studiu);
        }
    }
}
