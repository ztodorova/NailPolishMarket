namespace NailPolishMarket.Data.Repositories
{
    using System.Linq;
    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> All();

        TEntity FindById(object id);

        void Add(TEntity TEntity);

        void Remove(TEntity TEntity);

        void Update(TEntity Entity);

        void SaveChanges();
    }
}
