using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Profesor: MembruFacultate, ISituatie
    {
        string cabinet;
        string telefon;
        string email;
        List<Disciplina> discipline = new List<Disciplina>();
        List<Note> note = new List<Note>();

        public string Cabinet
        {
            get { return cabinet; }
            set { cabinet = value; }
        }

        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
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
      
        public Profesor(string nume_membru, string prenume_membru, string cabinet, string telefon, string email)
            :base(nume_membru, prenume_membru)
        {       
            this.cabinet = cabinet;
            this.telefon = telefon;
            this.email = email;
        }
    }
}
