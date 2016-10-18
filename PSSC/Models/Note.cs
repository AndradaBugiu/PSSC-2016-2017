using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    enum TipNota{
        nota_examen,
        nota_activitate
    };

    class Note
    {
        Disciplina disciplina;
        TipNota tip_nota;
        Student student;

        public Disciplina Disciplina
        {
            get { return disciplina; }
            set { disciplina = value; }
        }

        public TipNota Tip_nota
        {
            get { return tip_nota; }
            set { tip_nota = value; }
        }

        public Student Student
        {
            get { return student; }
            set { student = value; }
        }

        public Note(Disciplina disciplina, TipNota tip_nota, Student student)
        {
            this.disciplina = disciplina;
            this.tip_nota = tip_nota;
            this.student = student;
        }
    }
}
