using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Facultate: Universitate
    {
        public string nume_facultate;
        public string adresa;
        public string telefon;

        public Facultate(int id_universitate, string nume_universitate, string nume_facultate, string adresa, 
            string telefon):base(id_universitate, nume_universitate)
        {
            this.nume_facultate = nume_facultate;
            this.adresa = adresa;
            this.telefon = telefon;
        }
    }
}
