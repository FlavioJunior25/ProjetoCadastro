using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCadastro.UI.ViewModels
{
    public class PessoaViewModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo DataNascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Preencha o campo TelefoneFixo")]
        public int TelefoneFixo { get; set; }

        [Required(ErrorMessage = "Preencha o campo Celular")]
        public int Celular { get; set; }

        [Required(ErrorMessage = "Preencha o campo EstadoCivil")]
        public string EstadoCivil { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }


    }
}