using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProviderITProvaPratica.Models
{
    public class Aluno
    {
        public int AlunoID { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string EMail { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string Celular { get; set; }
        public string TelefoneResidencial { get; set; }
        public DateTime DataMatricula { get; set; }
        public ICollection<Turma> Turmas { get; set; }
    }
}
