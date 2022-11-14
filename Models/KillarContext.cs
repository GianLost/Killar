using Microsoft.EntityFrameworkCore;

// Classe de Contexto que herda DbContext para o gerenciamento de tabelas com Entity Framework Core

namespace Killar.Models
{
    public class KillarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;DataBase=dbkillar;Uid=root;"); // String de conexão
        }

        public DbSet<Users> Usuarios { get; set; }

    }

}