using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalleStore.Models;

[Table("Tamanho")]
public class Tamanho
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe a sigla")]
    [StringLength(5, ErrorMessage = "A sigla deve possuir no máximo 5 caracteres")]
    public string Sigla { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres")]
    public string Nome { get; set; }

    public ICollection<Estoque> Estoque { get; set; }
}