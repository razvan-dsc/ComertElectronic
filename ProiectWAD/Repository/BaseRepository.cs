using ProiectWAD.Interfaces.Repository;
using ProiectWAD.Models;

namespace ProiectWAD.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : EntityClass
    {
        protected readonly ProiectWADDBContext _dbContext;
        public BaseRepository(ProiectWADDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public T Add(T entity)
        {
            var returnEntity = _dbContext.Set<T>().Add(entity).Entity;

            _dbContext.SaveChanges();

            return returnEntity;
        }

        public void Delete(int id)
        {
            var deleteItem = _dbContext.Set<T>().Single(item => item.Id == id);

            _dbContext.Set<T>().Remove(deleteItem);

            _dbContext.SaveChanges();
        }

        public ICollection<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            var itemFind = _dbContext.Set<T>().Single(item => item.Id == id);

            return itemFind;
        }

        public T Update(T entity)
        {
            var itemUpdate = _dbContext.Set<T>().Update(entity).Entity;

            _dbContext.SaveChanges();

            return itemUpdate;
        }
    }
}
