using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using QBuy.Domínio.Entidades;

namespace QBuy.Repositório.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            ///Padrão fluent
            
            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);


            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);


            builder
                .Property(u => u.SobreNome)
                .IsRequired()
                .HasMaxLength(50);


            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400);


            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);


        }
    }
}
