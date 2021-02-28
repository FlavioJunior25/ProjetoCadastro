using System;

namespace ProjetoCadastro.Domain.Entities
{
    public class Pessoa
    {
        public int Id { get; set;  }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public int TelefoneFixo { get; set; }
        public int Celular { get; set; }
        public string EstadoCivil { get; set; }

    }
}
