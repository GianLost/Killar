using Microsoft.EntityFrameworkCore;

// Classe de Contexto que herda DbContext para o gerenciamento de tabelas com Entity Framework Core

namespace Killar.Models
{
    public class KillarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;port=3306;database=dbkillar;uid=root;SslMode=None;ConvertZeroDateTime=true;pooling=no");
        }
        
        public DbSet<Users> Usuarios { get; set; }
        public DbSet<Posts> Posters { get;set; }
        public DbSet<Comments> Comentarios { get;set;}

    }

}