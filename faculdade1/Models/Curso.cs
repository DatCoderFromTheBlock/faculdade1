using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace faculdade1.Models
{
    public class Curso
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CursoID { get; set; }
        public String Nome { get; set; }
        public virtual ICollection<Disciplina> Disciplinas { get; set; }
    }
}