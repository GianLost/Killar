using Microsoft.EntityFrameworkCore;

// Classe de Contexto que herda DbContext para o gerenciamento de tabelas com Entity Framework Core

namespace Killar.Models
{
    public class KillarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=MYSQL8001.site4now.net;Database=db_a8d790_datakil;Uid=a8d790_datakil;Pwd=Ann@1170615"); // String de conexão
        }

        public DbSet<Users> Usuarios { get; set; }

    }

}