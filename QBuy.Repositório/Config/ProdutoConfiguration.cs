using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QBuy.Domínio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QBuy.Repositório.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {


            builder.HasKey(p => p.Id);

            ///Padrão fluent

            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(p => p.Preco)
                .IsRequired();


            
                




        }
    }
}
