using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.MVC_Cursos
{
    internal class Disciplina
    {
        public int Id { get; set; }
        public string Descricao { get; private set; }
        public List<Aluno> Alunos { get; private set; }

        public Disciplina(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
            Alunos = new List<Aluno>();
        }

        public bool MatricularAluno(Aluno aluno)
        {
            if (Alunos.Count < 15 && !Alunos.Contains(aluno))
            {
                if (aluno.PodeMatricular(null))
                {
                    Alunos.Add(aluno);
                    aluno.Disciplinas.Add(this);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool DesmatricularAluno(Aluno aluno)
        {
            if (Alunos.Contains(aluno))
            {
                Alunos.Remove(aluno);
                aluno.Disciplinas.Remove(this);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Disciplina ID: {Id}, Descrição: {Descricao}, Alunos: {string.Join(", ", Alunos.ConvertAll(a => a.Nome))}";
        }
    }
}
