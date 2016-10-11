using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Orar
    {
        public Disciplina disciplina;
        public string zi;
        public string ora;
        public int an_studiu;

        public Orar(Disciplina disciplina, string zi, string ora, int an_studiu)
        {
            this.disciplina = disciplina;
            this.zi = zi;
            this.ora = ora;
            this.an_studiu = an_studiu;
        }
    }
}
