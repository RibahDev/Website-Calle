using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalleStore.Models
{
    [Table("AppUser")]
   public class AppUser
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o seu nome completo por favor")]
        [StringLength(70, ErrorMessage = "O nome deve possuir no máximo 50 caracteres")]
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Por favor preencha o email")]
        [EmailAddress]
        [StringLength(100, ErrorMessage = "O email deve possuir no máximo 100 caracteres")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor preencha a senha")]
        [StringLength(16, ErrorMessage = "A senha deve possuir no máximo 16 caracteres")]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Por favor preencha o CPF")]
        [Display(Name = "CPF")]
        [StringLength(14, ErrorMessage = "CPF INVÁLIDO")]
        public string CPF { get; set; }
    }
}