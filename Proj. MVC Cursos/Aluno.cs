using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.MVC_Cursos
{
    internal class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Disciplina> Disciplinas { get; set; }

        public Aluno(int id, string nome)
        {
            Id = id;
            Nome = nome;
            Disciplinas = new List<Disciplina>();
        }

        public bool PodeMatricular(Curso curso)
        {
            return Disciplinas.Count < 6;
        }

        public override string ToString()
        {
            return $"Aluno ID: {Id}, Nome: {Nome}, Disciplinas: {string.Join(", ", Disciplinas.ConvertAll(d => d.Descricao))}";
        }
    }
}
