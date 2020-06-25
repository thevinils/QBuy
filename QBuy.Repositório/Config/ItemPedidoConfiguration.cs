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


            builder.HasKey(I => I.Id);


            ///Padrão fluent



            

            builder
                .Property(I => I.ProdutoId)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(I => I.Quantidade)
                .IsRequired()
                .HasMaxLength(50);







        }
    }
}
