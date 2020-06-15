using System;
using System.Collections.Generic;
using System.Text;

namespace QBuy.Domínio.Entidades
{
    public class Produto : Entidade
    {

        public int Id { get; set; }

        public String Nome { get; set; }

        public String Descricao { get; set; }

        public decimal Preco { get; set; }

        
        
        
        public override void Validate()
        {

            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome deve estar preenchido");

        }
    }
}
