using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBiblioteca.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("UsuarioId")]
        [Display(Name = "Identificação do usuário")]
        public int UsuarioId { get; set; }

        [Column("NomeUsuario")]
        [Display(Name = "Nome do usuário")]
        public string NomeUsuario { get; set; } = string.Empty;

        [Column("RmUsuario")]
        [Display(Name = "Rm do usuário")]
        public string RmUsuario { get; set; } = string.Empty;
    }
}
