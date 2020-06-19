using Microsoft.EntityFrameworkCore;
using QBuy.Domínio.Entidades;
using QBuy.Domínio.Entidades.ObjetoDeValor;
using QBuy.Repositório.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace QBuy.Repositório.Context
{
     public class QuickBuyContext : DbContext
    {
        
        
        

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<ItemPedido> ItensPedidos { get; set; }

        public DbSet<FormaPagamento> FormaPagamento { get; set; }





        public QuickBuyContext(DbContextOptions options) : base(options)
        {



        }


    }
}
