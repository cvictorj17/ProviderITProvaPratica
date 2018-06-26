using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProviderITProvaPratica.Models
{
    public class Disciplina
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DisciplinaID { get; set; }
        public string NomeDisciplina { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public string CodigoDisciplina { get; set; }
        public ICollection<Turma> Turmas { get; set; }
    }
}
