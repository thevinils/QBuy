using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QBuy.Domínio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QBuy.Repositório.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            throw new NotImplementedException();
        }
    }
}
