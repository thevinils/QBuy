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
            throw new NotImplementedException();
        }
    }
}
