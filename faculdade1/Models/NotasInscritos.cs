using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace faculdade1.Models
{
    public class NotasInscritos
    {
        public int ID { get; set; }
        public int DisciplinaID { get; set; }
        public int StudentID { get; set; }
        public int Nota { get; set; }
        public virtual Student Student { get; set; }
        public virtual Disciplina Disciplina { get; set; }
    }
}