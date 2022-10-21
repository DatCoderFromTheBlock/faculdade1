using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using faculdade1.Models;


namespace faculdade1.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{StudentID = 1,Nome="Carson Alexander",BirthDate=DateTime.Parse("2005-09-01")},
            new Student{StudentID = 2,Nome="Meredith Alonso",BirthDate=DateTime.Parse("2002-09-01")},
            new Student{StudentID = 3,Nome="Arturo Anand",BirthDate=DateTime.Parse("2003-09-01")},
            new Student{StudentID = 4,Nome="Gytis Barzdukas",BirthDate=DateTime.Parse("2002-09-01")},
            new Student{StudentID = 5,Nome="Yan Li",BirthDate=DateTime.Parse("2002-09-01")},
            new Student{StudentID = 6,Nome="Peggy Justice",BirthDate=DateTime.Parse("2001-09-01")},
            new Student{StudentID = 7,Nome="Laura Norman",BirthDate=DateTime.Parse("2003-09-01")},
            new Student{StudentID = 8,Nome="Nino Olivetto",BirthDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            Curso CHEM = new Curso { CursoID = 1001, Nome = "Chemical Engineering", };
            Curso CS = new Curso { CursoID = 1002, Nome = "Computer Science" };
            Curso EE = new Curso { CursoID = 1003, Nome = "Electrotecnical engineering" };
            Curso MATH = new Curso { CursoID = 1004, Nome = "Mathmathics" };
            Curso BIO = new Curso { CursoID = 1005, Nome = "Biology" };
            Curso GEO = new Curso { CursoID = 1006, Nome = "Geology" };
            Curso LIT = new Curso { CursoID = 1007, Nome = "Literature" };
            var cursos = new List<Curso>
            {CHEM, CS, EE, MATH, BIO, GEO, LIT,
            };
            cursos.ForEach(s => context.Cursos.Add(s));
            context.SaveChanges();
            Professor Aurelio = new Professor { ProfessorID = 1, BirthDate = DateTime.Parse("1990-09-01"), Salary = 1983.30, Nome = "Aurelio" };
            Professor Berta = new Professor { ProfessorID = 2, BirthDate = DateTime.Parse("1970-08-02"), Salary = 2500.26, Nome = "Berta" };
            Professor Carlos = new Professor { ProfessorID = 3, BirthDate = DateTime.Parse("1980-10-06"), Salary = 2325.20, Nome = "Carlos" };
            Professor Diana = new Professor { ProfessorID = 4, BirthDate = DateTime.Parse("1985-02-04"), Salary = 1530.56, Nome = "Diana" };
            var professors = new List<Professor>
            { Aurelio, Berta, Carlos, Diana
            };
            Disciplina CE = new Disciplina { DisciplinaID = 1050, nome = "Chemistry", Professor = Aurelio, };
            Disciplina MIE = new Disciplina { DisciplinaID = 4022, nome = "Microeconomics", Professor = Berta };
            Disciplina MAE = new Disciplina { DisciplinaID = 4041, nome = "Macroeconomics", Professor = Berta };
            Disciplina CA = new Disciplina { DisciplinaID = 1045, nome = "Calculus", Professor = Carlos };
            Disciplina TRI = new Disciplina { DisciplinaID = 3141, nome = "Trigonometry", Professor = Carlos };
            Disciplina CO = new Disciplina { DisciplinaID = 2021, nome = "Composition", Professor = Diana };
            Disciplina LI = new Disciplina { DisciplinaID = 2042, nome = "Literature", Professor = Diana };
            professors.ForEach(s => context.Professors.Add(s));
            context.SaveChanges();
            var disciplinas = new List<Disciplina>
            {CE, MIE, MAE, CA, TRI, CO, LI
            
            };
            disciplinas.ForEach(s => context.Disciplinas.Add(s));
            context.SaveChanges();
            var DisciplinasAssociadas = new List<DisciplinasAssociadas> { new DisciplinasAssociadas{ DisciplinaID = 1050, CursoID = 1001, Disciplina = CE, Curso = CHEM },
                new DisciplinasAssociadas {DisciplinaID = 1045, CursoID = 1001, Disciplina = CA, Curso = CHEM },
                new DisciplinasAssociadas {DisciplinaID = 1045, CursoID = 1002, Disciplina = CA, Curso = CS },
                new DisciplinasAssociadas {DisciplinaID = 3145, CursoID = 1002, Disciplina = TRI, Curso = CS },
                new DisciplinasAssociadas {DisciplinaID = 1045, CursoID = 1003, Disciplina = CA, Curso = EE },
                new DisciplinasAssociadas {DisciplinaID = 1045, CursoID = 1004, Disciplina = CA, Curso = CS },
                new DisciplinasAssociadas {DisciplinaID = 1050, CursoID = 1005, Disciplina = CE, Curso = CS },
            };
            DisciplinasAssociadas.ForEach(s => context.DisciplinasAssociadas.Add(s));
            context.SaveChanges();
            Student carson = new Student { StudentID = 1, Nome = "Carson Alexander", BirthDate = DateTime.Parse("2005-09-01") };
            var NotasInscritos = new List<NotasInscritos> { new NotasInscritos { ID = 0,  DisciplinaID = 1045, StudentID = 1, Nota = 15, Student = carson, Disciplina = CA } };
       

        }
    }
}