using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O nome é um campo obrigatório para ser preenchido!")]
        public string Nome { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "A observação é um campo obrigatório e deve ter 5 até 50 caracteres!"), Required(ErrorMessage = "A observação é um campo obrigatório para ser preenchido!")]
        public string Observacao { get; set; }
        [Range(18, 70, ErrorMessage = "A idade tem que está entre 18 e 70 anos!")]
        public int Idade { get; set; }
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Digite um e-mail valido!")]
        public string Email { get; set; }
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente letras e de 5 a 15 caracteres!")]
        [Required(ErrorMessage = "O login é obrigatório!")]

        [Remote("LoginUnico", "Usuario", ErrorMessage = "Este login já existe, digite outro!")]
        public string Login { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória!")]
        public string Senha { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "As senhas devem ser iguais!")]
        [Required(ErrorMessage = "A confirmação de senha também é obrigatória!!!")]
        public string ConfirmarSenha { get; set; }
    }
}