using Microsoft.EntityFrameworkCore;

    namespace SistemaBiblioteca.Models
    {
        public class Contexto : DbContext
        {
            public Contexto(DbContextOptions<Contexto> options) : base(options)
            {

            }
            public DbSet<Usuario> Usuario { get; set; }
            public DbSet<Livro> Livro { get; set; }
            public DbSet<Autor> Autor { get; set; }
            public DbSet<Emprestimo> Emprestimo { get; set; }
            public DbSet<Genero> Genero { get; set; }
    }
    }