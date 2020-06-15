using System;
using System.Collections.Generic;
using System.Text;

namespace QBuy.Domínio.Entidades
{
    class Usuario : Entidade 
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int Senha { get; set; }

        public string Nome { get; set; }

        public String SobreNome { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email deve estar preenchido");

            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome deve estar preenchido");
        }
    }
}
