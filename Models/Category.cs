using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalleStore.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Por favor insíra o nome da categoria")]
        [StringLength(20, ErrorMessage = "O nome deve possuír no máximo 20 caracteres")]
        public string Nome { get; set; }

        public ICollection<Product> Products { get; set; }
        
    }
}