using System;
using CadastroNotas.Controllers;
using CadastroNotas.Views;

namespace CadastroNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new AlunoController();
            bool continuar = true;

            while (continuar)
            {
                View.ExibirMenu();
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        View.LimparTela();
                        Console.Write("Nome do Aluno: ");
                        var nome = Console.ReadLine();
                        Console.Write("Nota 1 de Português: ");
                        var nota1Portugues = double.Parse(Console.ReadLine());
                        Console.Write("Nota 2 de Português: ");
                        var nota2Portugues = double.Parse(Console.ReadLine());
                        Console.Write("Nota 1 de Matemática: ");
                        var nota1Matematica = double.Parse(Console.ReadLine());
                        Console.Write("Nota 2 de Matemática: ");
                        var nota2Matematica = double.Parse(Console.ReadLine());

                        controller.CadastrarAluno(nome, nota1Portugues, nota2Portugues, nota1Matematica, nota2Matematica);
                        break;

                    case "2":
                        View.LimparTela();
                        controller.MostrarBoletim();
                        break;

                    case "3":
                        continuar = false;
                        break;

                    default:
                        View.LimparTela();
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }
            }
        }
    }
}
