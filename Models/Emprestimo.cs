using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBiblioteca.Models
{
    [Table("Emprestimo")]
    public class Emprestimo
    {
        [Column("EmprestimoId")]
        [Display(Name = "Identificação do emprestimo")]
        public int EmprestimoId { get; set; }

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        [ForeignKey("LivroId")]
        public int LivroId { get; set; }
        public Livro? Livro { get; set; }

        [Column("DataInicioEmprestimo")]
        [Display(Name = "Data de inicio do emprestimo")]
        public DateTime DataInicioEmprestimo { get; set; }

        [Column("DataFimEmprestimo")]
        [Display(Name = "Data do fim do emprestimo")]
        public DateTime DataFimEmprestimo { get; set; }

        [Column("StatusEmprestimo")]
        [Display(Name = "Status do emprestimo")]
        public bool StatusEmprestimo { get; set; }
    }
}
