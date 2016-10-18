using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    enum TipEvaluare
    {
        distribuita,
        examen
    };

    class Disciplina
    {
        string nume_disciplina;
        Profesor nume_profesor;
        TipEvaluare tip_evaluare;
        int an_studiu;

        public string Nume_disciplina
        {
            get { return nume_disciplina; }
            set { nume_disciplina = value; }
        }

        public Profesor Nume_profesor
        {
            get { return nume_profesor; }
            set { nume_profesor = value; }
        }

        public TipEvaluare Tip_evaluare
        {
            get { return tip_evaluare; }
            set { tip_evaluare = value; }
        }

        public int An_studiu
        {
            get { return an_studiu; }
            set { an_studiu = value; }
        }

        public Disciplina(string nume_disciplina, Profesor nume_profesor, TipEvaluare tip_evaluare, int an_studiu)
        {
            this.nume_disciplina = nume_disciplina;
            this.nume_profesor = nume_profesor;
            this.tip_evaluare = tip_evaluare;
            this.an_studiu = an_studiu;
        }
    }
}
