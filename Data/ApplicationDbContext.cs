using Microsoft.EntityFrameworkCore;
using CadastroNotas.Models;

namespace CadastroNotas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=novo_notas_escolares;user=root;password=", new MySqlServerVersion(new Version(8, 0, 21)));
        }
    }
}
