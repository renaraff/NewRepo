using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBiblioteca.Models
{
    [Table("Autor")]
    public class Autor
    {
        [Column("AutorId")]
        [Display(Name = "Identificação do autor")]
        public int AutorId { get; set; }

        [Column("NomeAutor")]
        [Display(Name = "Nome do autor")]
        public string NomeAutor { get; set; } = string.Empty;
    }
}
