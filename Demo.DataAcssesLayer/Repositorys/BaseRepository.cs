using Demo.DataAcssesLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAcssesLayer.Repositorys
{
    public class BaseRepository<TEntity>(CompanyDbContext Context) : IRepository<TEntity> where TEntity : BaseEntity
    {
        
        private DbSet<TEntity> _dbSet = Context.Set<TEntity>();


        public virtual int Add(TEntity TEntity)
        {
            _dbSet.Add(TEntity);
            return Context.SaveChanges();
        }

        public virtual int  Delete(TEntity TEntity)
        {
            TEntity.IsDeleted=true;
            _dbSet.Remove(TEntity);
            return Context.SaveChanges();
        }



        public virtual IEnumerable<TEntity> GetAll(bool ChangeTranking = false)
        {
            return ChangeTranking ? _dbSet.Where(x=> !x.IsDeleted).ToList() :
                    _dbSet.Where(x => !x.IsDeleted).AsNoTracking().ToList();
        }

        public virtual TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual int Update(TEntity TEntity)
        {
            _dbSet.Update(TEntity);
            return Context.SaveChanges();
        }
    }

}

