using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace faculdade1.Models
{
    

    public class Disciplina
    {
        public int DisciplinaID { get; set; }
        public String nome { get; set; }
        public int ProfessorID { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual ICollection<Student> Alunos { get; set; }
    }
}