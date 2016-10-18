using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    interface ISituatie
    {
        private List<Disciplina> Discipline
        {
            get; set;
        }

        private List<Note> Note
        {
            get; set;
        }
    }
}
