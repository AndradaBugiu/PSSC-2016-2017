using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Student: MembruFacultate, ISituatie
    {
        DateTime data_nasterii;
        string cnp;
        string adresa;
        string telefon;
        int an_studiu;
        int nr_credite;
        List<Disciplina> discipline = new List<Disciplina>();
        List<Note> note = new List<Note>();

        public DateTime Data_nasterii
        {
            get { return data_nasterii; }
            set { data_nasterii = value; }
        }

        public string Cnp
        {
            get { return cnp; }
            set { cnp = value; }
        }

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }

        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }

        public int An_studiu
        {
            get { return an_studiu; }
            set { an_studiu = value; }
        }
        
        public int Nr_credite
        {
            get { return nr_credite; }
            set { nr_credite = value; }
        }

        private List<Disciplina> Discipline
        {
            get { return discipline; }
            set { discipline = value; }
        }

        private List<Note> Note
        {
            get { return note; }
            set { note = value; }
        }

        public Student(string nume_membru, string prenume_membru, DateTime data_nasterii,
            string cnp, string adresa, string telefon, int an_studiu, int nr_credite)
            :base(nume_membru, prenume_membru)
        {          
            this.data_nasterii = data_nasterii;
            this.adresa = adresa;
            this.telefon = telefon;
            this.an_studiu = an_studiu;
            this.nr_credite = nr_credite;
        }
    }
}
