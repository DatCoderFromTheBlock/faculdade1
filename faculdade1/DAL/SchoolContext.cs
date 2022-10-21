using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using faculdade1.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace faculdade1.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=SchoolContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<DisciplinasAssociadas> DisciplinasAssociadas { get; set; }
        public DbSet<NotasInscritos> NotasInscritos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
