using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroNotas.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Nota1Portugues { get; set; }
        public double Nota2Portugues { get; set; }
        public double Nota1Matematica { get; set; }
        public double Nota2Matematica { get; set; }

        public Aluno() {}

        public Aluno(string nome)
        {
            Nome = nome;
        }

        public double CalcularMediaPortugues()
        {
            return (Nota1Portugues + Nota2Portugues) / 2;
        }

        public double CalcularMediaMatematica()
        {
            return (Nota1Matematica + Nota2Matematica) / 2;
        }

        public string SituacaoPortugues()
        {
            double media = CalcularMediaPortugues();
            return media >= 7.0 ? "Aprovado" : "Reprovado";
        }

        public string SituacaoMatematica()
        {
            double media = CalcularMediaMatematica();
            return media >= 7.0 ? "Aprovado" : "Reprovado";
        }
    }
}
