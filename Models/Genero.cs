using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBiblioteca.Models
{
    [Table("Genero")]
    public class Genero
    {
        [Column("GeneroId")]
        [Display(Name = "Identificação do gênero")]
        public int GeneroId { get; set; }

        [Column("NomeGenero")]
        [Display(Name = "Gênero")]
        public string NomeGenero { get; set; } = string.Empty;
    }
}
