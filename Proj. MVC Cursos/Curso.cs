using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.MVC_Cursos
{
    internal class Curso
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<Disciplina> Disciplinas { get; set; }

        public Curso(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
            Disciplinas = new List<Disciplina>();
        }

        public bool AdicionarDisciplina(Disciplina disciplina)
        {
            if (Disciplinas.Count < 12)
            {
                Disciplinas.Add(disciplina);
                return true;
            }
            return false;
        }
        public Disciplina PesquisarDisciplina(int id)
        {
            foreach (Disciplina d in Disciplinas)
            {
                if (d.Id == id)
                {
                    return d;
                }
            }
            return null; // Retorna null se não encontrar
        }
            
        public bool RemoverDisciplina(Disciplina disciplina)
        {
            if (disciplina.Alunos.Count == 0)
            {
                Disciplinas.Remove(disciplina);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Curso ID: {Id}, Descrição: {Descricao}, Disciplinas: {string.Join(", ", Disciplinas.ConvertAll(d => d.Descricao))}";
        }
    }

}
