using Microsoft.EntityFrameworkCore;

// Classe de Contexto que herda DbContext para o gerenciamento de tabelas com Entity Framework Core

namespace Killar.Models
{
    public class KillarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=mysql8001.site4now.net;port=3306;database=db_a90085_killdb;uid=a90085_killdb;password=Ann@1170615;SslMode=None;ConvertZeroDateTime=true;pooling=no");
        }

        public DbSet<Users> Usuarios { get; set; }
        public DbSet<Posts> Posters { get; set; }
        public DbSet<Comments> Comentarios { get; set; }

    }

}