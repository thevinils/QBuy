using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QBuy.Domínio.Entidades.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QBuy.Repositório.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            throw new NotImplementedException();
        }
    }
}
