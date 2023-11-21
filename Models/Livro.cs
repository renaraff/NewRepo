using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBiblioteca.Models
{
    [Table("Livro")]
    public class Livro
    {
        [Column("LivroId")]
        [Display(Name = "Identificação do livro")]
        public int LivroId { get; set; }

        [Column("TituloLivro")]
        [Display(Name = "Titulo do livro")]
        public string TituloLivro { get; set; } = string.Empty;

        [ForeignKey("GeneroId")]
        public int GeneroId { get; set; }
        public Genero? Genero { get; set; }

        [ForeignKey("AutorId")]
        public int AutorId { get; set; }
        public Autor? Autor { get; set; }

        [Column("QtdeLivro")]
        [Display(Name = "Quantidade do livro")]
        public int QtdeLivro { get; set; }
    }
}
