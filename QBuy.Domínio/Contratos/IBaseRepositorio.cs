using QBuy.Domínio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QBuy.Domínio.Contratos
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class 

    {

        void Adicionar(TEntity entity);

        TEntity ObterPorId(int id);

        IEnumerable<TEntity> Obtertodos();

        void Atualizar(TEntity entity);

        void Remover(TEntity entity);



    }
}
