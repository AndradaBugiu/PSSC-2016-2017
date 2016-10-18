using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Decanat:Facultate
    {
        Profesor decan;
        string sala;
        string email;
        string telefon;
        List<Disciplina> discipline = new List<Disciplina>();
        List<Profesor> profesori = new List<Profesor>();
        List<Student> studenti = new List<Student>();

        public Profesor Decan
        {
            get { return Decan; }
            set { decan = value; }
        }

        public string Sala
        {
            get { return sala; }
            set { sala = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }

        private List<Disciplina> Discipline
        {
            get { return discipline; }
            set { discipline = value; }
        }

        private List<Profesor> Profesori
        {
            get { return profesori; }
            set { profesori = value; }
        }

        private List<Student> Studenti
        {
            get { return studenti; }
            set { studenti = value; }
        }

        public Decanat(int id_universitate, string nume_universitate, string nume_facultate, string adresa, 
            string telefon_secretariat, Profesor decan, string sala, string email, string telefon, 
            List<Disciplina> discipline, List<Profesor> profesori, List<Student> studenti)
            :base(id_universitate, nume_universitate, nume_facultate, adresa, telefon_secretariat)
        {
            this.decan = decan;
            this.sala = sala;
            this.email = email;
            this.telefon = telefon;
            this.discipline = discipline;
            this.profesori = profesori;
            this.studenti = studenti;
        }
    }
}
