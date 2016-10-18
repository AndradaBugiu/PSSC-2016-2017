using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class MembruFacultate
    {
        string nume_membru;
        string prenume_membru;

        public string Nume_membru
        {
            get { return nume_membru; }
            set { nume_membru = value; }
        }

        public string Prenume_membru
        {
            get { return prenume_membru; }
            set { prenume_membru = value; }
        }

        public MembruFacultate(string nume_membru, string prenume_membru)
        {
            this.nume_membru = nume_membru;
            this.prenume_membru = prenume_membru;
        }
    }
}
