using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace faculdade1.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public int nrmatricula { get; set; }
        public string Nome { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual ICollection<NotasInscritos> notas { get; set; }

}
}