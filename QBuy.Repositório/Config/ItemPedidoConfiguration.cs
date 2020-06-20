using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QBuy.Domínio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QBuy.Repositório.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            throw new NotImplementedException();
        }
    }
}
