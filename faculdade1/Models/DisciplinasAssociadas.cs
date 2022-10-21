using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace faculdade1.Models
{
    public class DisciplinasAssociadas
    {
        public int ID { get; set; }
        public int DisciplinaID { get; set; }
        public int CursoID { get; set; }
        public virtual Disciplina Disciplina { get; set; }
        public virtual Curso Curso { get; set; }
    }
}