using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProviderITProvaPratica.Models;

namespace ProviderITProvaPratica.Data
{
    public class FaculdadeContexto : DbContext
    {
        public FaculdadeContexto(DbContextOptions<FaculdadeContexto> options) : base(options)
        {
        }

        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Turma>().ToTable("Turma");
            modelBuilder.Entity<Disciplina>().ToTable("Disciplina");
            modelBuilder.Entity<Aluno>().ToTable("Aluno");
        }
    }
}
