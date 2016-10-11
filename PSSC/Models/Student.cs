using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Student: MembruFacultate
    {
        public DateTime data_nasterii;
        public int varsta;
        public string cnp;
        public string adresa;
        public string telefon;
        public int an;

        public Student(string nume_membru, string prenume_membru, Departament departament, DateTime data_nasterii, 
            int varsta, string cnp, string adresa, string telefon, int an):base(nume_membru, prenume_membru, departament)
        {          
            this.data_nasterii = data_nasterii;
            this.varsta=varsta;
            this.adresa = adresa;
            this.telefon = telefon;
            this.an = an;
        }
    }
}
