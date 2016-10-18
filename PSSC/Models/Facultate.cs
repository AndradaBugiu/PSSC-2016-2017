using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Facultate
    {
        int id_universitate;
        string nume_universitate;
        string nume_facultate;
        string adresa;
        string telefon_secretariat;
        
        public int Id_universitate
        {
            get { return id_universitate; }
            set { id_universitate = value; }
        }

        public string Nume_universitate
        {
            get { return nume_universitate; }
            set { nume_universitate = value; }
        }

        public string Nume_facultate
        {
            get { return nume_facultate; }
            set { nume_facultate = value; }
        }

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }

        public string Telefon
        {
            get { return telefon_secretariat; }
            set { telefon_secretariat = value; }
        }

        public Facultate(int id_universitate, string nume_universitate, string nume_facultate, string adresa, 
            string telefon_secretariat)
        {
            this.id_universitate = id_universitate;
            this.nume_universitate = nume_universitate;
            this.nume_facultate = nume_facultate;
            this.adresa = adresa;
            this.telefon_secretariat = telefon_secretariat;
        }
    }
}
