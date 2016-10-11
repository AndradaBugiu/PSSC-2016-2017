using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Disciplina
    {
        public string nume_disciplina;
        public Profesor profesor;
        public Departament departament;

        public Disciplina(string nume_disciplina, Profesor profesor, Departament departament)
        {
            this.nume_disciplina = nume_disciplina;
            this.profesor = profesor;
            this.departament = departament;
        }
    }
}
