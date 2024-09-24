using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.MVC_Cursos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Escola escola = new Escola();
            int opcao;
            do
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Adicionar curso");
                Console.WriteLine("2. Pesquisar curso (mostrar disciplinas)");
                Console.WriteLine("3. Remover curso");
                Console.WriteLine("4. Adicionar disciplina no curso");
                Console.WriteLine("5. Pesquisar disciplina (mostrar alunos matriculados)");
                Console.WriteLine("6. Remover disciplina do curso");
                Console.WriteLine("7. Matricular aluno na disciplina");
                Console.WriteLine("8. Remover aluno da disciplina");
                Console.WriteLine("9. Pesquisar aluno (mostrar disciplinas matriculadas)");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o ID do curso: ");
                        int idCurso = int.Parse(Console.ReadLine());
                        Console.Write("Digite a descrição do curso: ");
                        string descricaoCurso = Console.ReadLine();
                        escola.AdicionarCurso(new Curso(idCurso, descricaoCurso));
                        break;
                    case 2:
                        Console.Write("Digite o ID do curso: ");
                        idCurso = int.Parse(Console.ReadLine());
                        Curso curso = escola.PesquisarCurso(idCurso);
                        if (curso != null)
                        {
                            Console.WriteLine(curso);
                        }
                        else
                        {
                            Console.WriteLine("Curso não encontrado.");
                        }
                        break;
                    case 3:
                        Console.Write("Digite o ID do curso: ");
                        idCurso = int.Parse(Console.ReadLine());
                        curso = escola.PesquisarCurso(idCurso);
                        if (curso != null && escola.RemoverCurso(curso))
                        {
                            Console.WriteLine("Curso removido com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Não foi possível remover o curso.");
                        }
                        break;
                    case 4:
                        Console.Write("Digite o ID do curso: ");
                        idCurso = int.Parse(Console.ReadLine());
                        curso = escola.PesquisarCurso(idCurso);
                        if (curso != null)
                        {
                            Console.Write("Digite o ID da disciplina: ");
                            int idDisciplina = int.Parse(Console.ReadLine());
                            Console.Write("Digite a descrição da disciplina: ");
                            string descricaoDisciplina = Console.ReadLine();
                            curso.AdicionarDisciplina(new Disciplina(idDisciplina, descricaoDisciplina));
                        }
                        break;
                    case 5:
                        Console.Write("Digite o ID do curso: ");
                        idCurso = int.Parse(Console.ReadLine());
                        curso = escola.PesquisarCurso(idCurso);
                        if (curso != null)
                        {
                            Console.Write("Digite o ID da disciplina: ");
                            int idDisciplina = int.Parse(Console.ReadLine());
                            Disciplina disciplina = curso.PesquisarDisciplina(idDisciplina);
                            if (disciplina != null)
                            {
                                Console.WriteLine(disciplina);
                            }
                            else
                            {
                                Console.WriteLine("Disciplina não encontrada.");
                            }
                        }
                        break;
                    case 6:
                        Console.Write("Digite o ID do curso: ");
                        idCurso = int.Parse(Console.ReadLine());
                        curso = escola.PesquisarCurso(idCurso);
                        if (curso != null)
                        {
                            Console.Write("Digite o ID da disciplina a ser removida: ");
                            int idDisciplina = int.Parse(Console.ReadLine());
                            Disciplina disciplina = curso.PesquisarDisciplina(idDisciplina);
                            if (disciplina != null)
                            {
                                if (disciplina.Alunos.Count == 0)
                                {
                                    if (curso.RemoverDisciplina(disciplina))
                                    {
                                        Console.WriteLine("Disciplina removida com sucesso.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Não é possível remover a disciplina, pois há alunos matriculados.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Disciplina não encontrada.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Curso não encontrado.");
                        }
                        break;
                    case 7:
                        Console.Write("Digite o ID do curso: ");
                        idCurso = int.Parse(Console.ReadLine());
                        curso = escola.PesquisarCurso(idCurso);
                        if (curso != null)
                        {
                            Console.Write("Digite o ID da disciplina: ");
                            int idDisciplina = int.Parse(Console.ReadLine());
                            Disciplina disciplina = curso.PesquisarDisciplina(idDisciplina);
                            if (disciplina != null)
                            {
                                Console.Write("Digite o ID do aluno: ");
                                int idAluno = int.Parse(Console.ReadLine());
                                Console.Write("Digite o nome do aluno: ");
                                string nomeAluno = Console.ReadLine();
                                Aluno aluno = new Aluno(idAluno, nomeAluno);
                                if (disciplina.MatricularAluno(aluno))
                                {
                                    Console.WriteLine("Aluno matriculado com sucesso.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Disciplina não encontrada.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Curso não encontrado.");
                        }
                        break;
                    case 8:
                        Console.Write("Digite o ID do curso: ");
                        idCurso = int.Parse(Console.ReadLine());
                        curso = escola.PesquisarCurso(idCurso);
                        if (curso != null)
                        {
                            Console.Write("Digite o ID da disciplina: ");
                            int idDisciplina = int.Parse(Console.ReadLine());
                            Disciplina disciplina = curso.PesquisarDisciplina(idDisciplina);
                            if (disciplina != null)
                            {
                                Console.Write("Digite o ID do aluno: ");
                                int idAluno = int.Parse(Console.ReadLine());
                                Aluno aluno = disciplina.Alunos.Find(a => a.Id == idAluno);
                                if (aluno != null && disciplina.DesmatricularAluno(aluno))
                                {
                                    Console.WriteLine("Aluno removido com sucesso.");
                                }
                                else
                                {
                                    Console.WriteLine("Aluno não encontrado ou já desmatriculado.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Disciplina não encontrada.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Curso não encontrado.");
                        }
                        break;
                    case 9:
                        Console.Write("Digite o ID do aluno: ");
                        int idAlunoPesquisa = int.Parse(Console.ReadLine());
                        Aluno alunoPesquisado = null;
                        foreach (Curso c in escola.Cursos)
                        {
                            foreach (Disciplina d in c.Disciplinas)
                            {
                                Aluno aluno = d.Alunos.Find(a => a.Id == idAlunoPesquisa);
                                if (aluno != null)
                                {
                                    alunoPesquisado = aluno;
                                    break;
                                }
                            }
                        }
                        if (alunoPesquisado != null)
                        {
                            Console.WriteLine($"Aluno: {alunoPesquisado.Nome}");
                            Console.WriteLine("Disciplinas matriculadas: ");
                            foreach (Disciplina d in alunoPesquisado.Disciplinas)
                            {
                                Console.WriteLine(d.Descricao);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Aluno não encontrado.");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 0);

        }
    }
}
