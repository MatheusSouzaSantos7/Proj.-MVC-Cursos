using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.MVC_Cursos
{
    internal class Escola
    {
        public List<Curso> Cursos { get; private set; }

        public Escola()
        {
            Cursos = new List<Curso>();
        }

        public bool AdicionarCurso(Curso curso)
        {
            if (Cursos.Count < 5)
            {
                Cursos.Add(curso);
                return true;
            }
            return false;
        }

        public Curso PesquisarCurso(int id)
        {
            return Cursos.Find(c => c.Id == id);
        }

        public bool RemoverCurso(Curso curso)
        {
            if (curso.Disciplinas.Count == 0)
            {
                Cursos.Remove(curso);
                return true;
            }
            return false;
        }
    }
}
