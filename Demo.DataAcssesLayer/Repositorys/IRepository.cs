using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAcssesLayer.Repositorys
{
    public interface IRepository<TEntity>  where TEntity  : BaseEntity
    {
        IEnumerable<TEntity> GetAll(bool ChangeTranking = false);

        TEntity GetById(int id);
        int Add(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
    }
}
