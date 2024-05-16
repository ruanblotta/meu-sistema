using System;
using CadastroNotas.Data;
using CadastroNotas.Models;
using System.Linq;

namespace CadastroNotas.Controllers
{
    public class AlunoController
    {
        private readonly ApplicationDbContext _context;

        public AlunoController()
        {
            _context = new ApplicationDbContext();
        }

        public void CadastrarAluno(string nome, double nota1Portugues, double nota2Portugues, double nota1Matematica, double nota2Matematica)
        {
            var aluno = new Aluno
            {
                Nome = nome,
                Nota1Portugues = nota1Portugues,
                Nota2Portugues = nota2Portugues,
                Nota1Matematica = nota1Matematica,
                Nota2Matematica = nota2Matematica
            };

            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            Console.WriteLine($"Aluno {aluno.Nome} cadastrado com sucesso!");
        }

        public void MostrarBoletim()
        {
            var alunos = _context.Alunos.ToList();

            if (!alunos.Any())
            {
                Console.WriteLine("Nenhum aluno cadastrado.");
                return;
            }

            foreach (var aluno in alunos)
            {
                Console.WriteLine($"===== Boletim do Aluno {aluno.Nome} =====");
                Console.WriteLine("Português:");
                Console.WriteLine($"Nota 1: {aluno.Nota1Portugues}, Nota 2: {aluno.Nota2Portugues}, Média: {aluno.CalcularMediaPortugues()}, Situação: {aluno.SituacaoPortugues()}");
                Console.WriteLine("Matemática:");
                Console.WriteLine($"Nota 1: {aluno.Nota1Matematica}, Nota 2: {aluno.Nota2Matematica}, Média: {aluno.CalcularMediaMatematica()}, Situação: {aluno.SituacaoMatematica()}");
                Console.WriteLine("====================");
            }
        }
    }
}
