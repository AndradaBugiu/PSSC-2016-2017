using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class Departament
    {
        public string nume_departament;
        public string sef_departament;
        public Facultate facultate;

        public Departament(string nume_departament, string sef_departament, Facultate facultate)
        {
            this.nume_departament = nume_departament;
            this.sef_departament = sef_departament;
            this.facultate = facultate;
        }
    }
}
