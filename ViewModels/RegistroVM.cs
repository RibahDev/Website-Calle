using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalleStore.ViewModels;
    public class RegistroVM
    {
    [Display(Name = "Nome Completo")]
    [Required(ErrorMessage = "Preencha o seu nome completo.")]
    public string NomeCompleto { get; set; }

    [Required(ErrorMessage = "Por favor preencha o email.")]
    [EmailAddress]
    public string Email { get; set; }

    [Required(ErrorMessage = "Por favor preencha a senha.")]
    [StringLength(16, ErrorMessage = "A senha deve ter entre {2} e {1} caracteres.", MinimumLength = 6)]
    public string Senha { get; set; }

    [Required(ErrorMessage = "Por favor preencha o CPF.")]
    [StringLength(14, ErrorMessage = "CPF inválido.")]
    public string CPF { get; set; }
}
