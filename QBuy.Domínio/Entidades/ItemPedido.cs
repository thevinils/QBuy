using System;
using System.Collections.Generic;
using System.Text;

namespace QBuy.Domínio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }

        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            
        }
    }
}
