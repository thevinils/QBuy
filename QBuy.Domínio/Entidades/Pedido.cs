 using QBuy.Domínio.Entidades.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QBuy.Domínio.Entidades
{
    public class Pedido : Entidade
    {

        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string EnderecoCompleto { get; set; }

        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }

        public FormaPagamento FormaPagamento { get; set; }


        /// <summary>
        /// USUARIO DEVE TER UM OU MAIS PEDIDOS
        /// </summary>

        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            if (!ItensPedido.Any())
                AdicionarCritica("Pedido não pode ficar sem item de pedido");


            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("CEP deve estar preenchido");

            
            if (string.IsNullOrEmpty(Estado))
                AdicionarCritica("Estado deve estar preenchido");

            if (string.IsNullOrEmpty(Cidade))
                AdicionarCritica("Cidade deve estar preenchido");

            if (string.IsNullOrEmpty(EnderecoCompleto))
                AdicionarCritica("Endereço deve estar preenchido");

           

            if (string.IsNullOrEmpty(Estado))
                AdicionarCritica("Estado deve estar preenchido");









        }
    }
}
