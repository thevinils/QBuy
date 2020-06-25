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
           
            

            builder.HasOne(p => p.Usuario);


            ///Padrão fluent



            builder
                .Property(p => p.DataPedido)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.UsuarioId)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.DataPrevisaoEntrega)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(15);

            builder
                .Property(p => p.Estado)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(40);

            builder
                .Property(p => p.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.NumeroEndereco)
                .IsRequired()
                .HasMaxLength(15);

            builder
                .Property(p => p.FormaPagamentoId)
                .IsRequired()
                .HasMaxLength(40);




        }
    }
}
