using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Profesor: MembruFacultate
    {
        public Disciplina disciplina;
        public string cabinet;
        public string telefon;
        public string email;

        public Profesor(string nume_membru, string prenume_membru, , Departament departament, Disciplina disciplina, 
            string cabinet, string telefon, string email):base(nume_membru,prenume_membru,departament)
        {       
            this.disciplina = disciplina;
            this.cabinet = cabinet;
            this.telefon = telefon;
            this.email = email;
        }
    }
}
