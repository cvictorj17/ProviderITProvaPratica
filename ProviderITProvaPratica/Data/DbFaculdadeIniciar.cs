using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProviderITProvaPratica.Models;

namespace ProviderITProvaPratica.Data
{
    public class DbFaculdadeIniciar
    {
        public static void Initialize(FaculdadeContexto context)
        {
            context.Database.EnsureCreated();
            // procura por qualquer estudante
            if (context.Alunos.Any())
            {
                return;  //O banco foi inicializado
            }

            var alunos = new Aluno[]
            {
            new Aluno{Matricula="012018",Nome="Silveira",Cpf="426.679.420-78",EMail="teste@teste.com.br",Endereco="Rua da Ajuda 128",Bairro="Centro",Cidade="Rio de Janeiro",Uf="RJ",Cep="21.000-000",Celular="(21)98877-6688",TelefoneResidencial="(21)3488-7799",DataMatricula=DateTime.Parse("2018-06-01")},
            new Aluno{Matricula="022018",Nome="Marcia",Cpf="808.140.740-57",EMail="teste1@teste.com.br",Endereco="Rua Maria Aparecida 60",Bairro="Iraja",Cidade="Rio de Janeiro",Uf="RJ",Cep="21.000-000",Celular="(21)94433-2123",TelefoneResidencial="",DataMatricula=DateTime.Parse("2018-04-01")},
            new Aluno{Matricula="032018",Nome="Roberta",Cpf="135.319.230-05",EMail="teste2@teste.com.br",Endereco="A. Bras de Pina 18",Bairro="Olaria",Cidade="Rio de Janeiro",Uf="RJ",Cep="21.000-000",Celular="(21)93456-5544",TelefoneResidencial="(21)4678-7799",DataMatricula=DateTime.Parse("2018-06-01")},
            new Aluno{Matricula="042018",Nome="Carlos",Cpf="812.331.100-12",EMail="teste3@teste.com.br",Endereco="Rua Custodia 33",Bairro="Meier",Cidade="Rio de Janeiro",Uf="RJ",Cep="21.000-000",Celular="(21)94325-1234",TelefoneResidencial="(21)3488-3399",DataMatricula=DateTime.Parse("2018-03-01")},
            };
            foreach (Aluno s in alunos)
            {
                context.Alunos.Add(s);
            }
            context.SaveChanges();

            var disciplinas = new Disciplina[]
            {
            new Disciplina{DisciplinaID=1050,NomeDisciplina="Quimica",Descricao="", DataCriacao=DateTime.Parse("2018-03-01"), CodigoDisciplina="1001"},
            new Disciplina{DisciplinaID=4022,NomeDisciplina="Economia",Descricao="", DataCriacao=DateTime.Parse("2018-03-01"), CodigoDisciplina="1002"},
            new Disciplina{DisciplinaID=4041,NomeDisciplina="Economia",Descricao="", DataCriacao=DateTime.Parse("2018-03-01"), CodigoDisciplina="1003"},
            new Disciplina{DisciplinaID=1045,NomeDisciplina="Cálculo",Descricao="", DataCriacao=DateTime.Parse("2018-03-01"), CodigoDisciplina="1004"},
            new Disciplina{DisciplinaID=3141,NomeDisciplina="Trigonometria",Descricao="", DataCriacao=DateTime.Parse("2018-03-01"), CodigoDisciplina="1005"}
            };
            foreach (Disciplina c in disciplinas)
            {
                context.Disciplinas.Add(c);
            }
            
            context.SaveChanges();

            var turmas = new Turma[]
            {
            new Turma{TurmaID=1,CodigoTurma="1003",Curso="Sistema da Informação", Periodo=1, DisciplinaID=1050,AlunoID=1, DataCriacao=DateTime.Parse("2018-03-01")},
            new Turma{TurmaID=2,CodigoTurma="1003",Curso="Sistema da Informação", Periodo=1, DisciplinaID=1050,AlunoID=2, DataCriacao=DateTime.Parse("2018-03-01")},
            new Turma{TurmaID=3,CodigoTurma="1003",Curso="Sistema da Informação", Periodo=1, DisciplinaID=1050,AlunoID=3, DataCriacao=DateTime.Parse("2018-03-01")},
            new Turma{TurmaID=4,CodigoTurma="1003",Curso="Sistema da Informação", Periodo=1, DisciplinaID=1050,AlunoID=4, DataCriacao=DateTime.Parse("2018-03-01")},
            new Turma{TurmaID=5,CodigoTurma="1004",Curso="Suporte",Periodo=1, DisciplinaID=4022,AlunoID=2, DataCriacao=DateTime.Parse("2018-03-01")},
            new Turma{TurmaID=6,CodigoTurma="1004",Curso="Suporte",Periodo=1, DisciplinaID=4022,AlunoID=3, DataCriacao=DateTime.Parse("2018-03-01")},
            new Turma{TurmaID=7,CodigoTurma="1004",Curso="Suporte",Periodo=1, DisciplinaID=4022,AlunoID=4, DataCriacao=DateTime.Parse("2018-03-01")},
            new Turma{TurmaID=8,CodigoTurma="1005",Curso="Desenvolvimento",Periodo=1, DisciplinaID=4041, AlunoID=3,DataCriacao=DateTime.Parse("2018-03-01")},
            new Turma{TurmaID=9,CodigoTurma="1006",Curso="Engenharia",Periodo=1, DisciplinaID=1050,AlunoID=2, DataCriacao=DateTime.Parse("2018-03-01")},
            new Turma{TurmaID=10,CodigoTurma="1007",Curso="Ciência da Computação", Periodo=1, DisciplinaID=1045,AlunoID=1, DataCriacao=DateTime.Parse("2018-03-01")},
            new Turma{TurmaID=11,CodigoTurma="1007",Curso="Ciência da Computação", Periodo=1, DisciplinaID=1045,AlunoID=2, DataCriacao=DateTime.Parse("2018-03-01")},
            new Turma{TurmaID=12,CodigoTurma="1007",Curso="Ciência da Computação", Periodo=1, DisciplinaID=1045,AlunoID=4, DataCriacao=DateTime.Parse("2018-03-01")}
            };
            foreach (Turma c in turmas)
            {
                context.Turmas.Add(c);
            }

            context.SaveChanges();
        }
    }
}
