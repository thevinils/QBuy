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
            throw new NotImplementedException();
        }
    }
}
