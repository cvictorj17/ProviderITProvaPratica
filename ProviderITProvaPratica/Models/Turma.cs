using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProviderITProvaPratica.Models
{
    public class Turma
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TurmaID { get; set; }
        public string CodigoTurma { get; set; }
        public string Curso { get; set; }
        public int Periodo { get; set; }
        public int DisciplinaID { get; set; }
        public int AlunoID { get; set; }
        public DateTime DataCriacao { get; set; }
        public Disciplina Disciplina { get; set; }
        public Aluno Aluno { get; set; }
    }
}
