using QBuy.Domínio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QBuy.Repositório.Repositorios
{
     public class Client
    {

        public Client()
        {
            var usuarioRepositorio = new UsuarioRepositorio();
            var produto = new Produto();
            var usuario = new UsuarioRepositorio();

            usuarioRepositorio.Adicionar(usuario); 



        }

    }
}
