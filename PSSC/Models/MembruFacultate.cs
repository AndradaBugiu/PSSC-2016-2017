using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class MembruFacultate
    {
        public string nume_membru;
        public string prenume_membru;
        public Departament departament;

        public MembruFacultate(string nume_membru, string prenume_membru, Departament departament)
        {
            this.nume_membru = nume_membru;
            this.prenume_membru = prenume_membru;
            this.departament = departament;
        }
    }
}
