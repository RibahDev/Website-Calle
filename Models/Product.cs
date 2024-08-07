using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalleStore.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Por favor insíra o nome do produto")]
        [StringLength(100, ErrorMessage = "O nome deve possuír no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Por favor insíra a descrição")]
        [StringLength(500, ErrorMessage = "O nome deve possuír no máximo 100 caracteres")]
        public string Descricao { get; set; }


        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Required(ErrorMessage = "Por favor insíra um preço")]
        public decimal Preco { get; set; }

        [Display(Name = "Quantidade no Estoque")]
        [Required(ErrorMessage = "Informe a quantidade no estoque")]
        public int QtdEstoque { get; set; }

        [StringLength(300)]
        public string Foto { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Informe a Categoria")]
        public int CategoryId {get; set;}
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        
    }
}