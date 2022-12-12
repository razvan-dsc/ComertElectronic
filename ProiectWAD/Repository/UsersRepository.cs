using ProiectWAD.Interfaces.Repository;
using ProiectWAD.Models;

namespace ProiectWAD.Repository
{
    internal class UsersRepository :  IUsersRepository
    {
        protected readonly ProiectWADDBContext _dbContext;
        public UsersRepository(ProiectWADDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public User Add(User entity)
        {
            var returnEntity = _dbContext.Users.Add(entity).Entity;

            _dbContext.SaveChanges();

            return returnEntity;
        }

        public void Delete(string id)
        {
            var deleteItem = _dbContext.Users.Single(item => item.Id == id);

            _dbContext.Users.Remove(deleteItem);

            _dbContext.SaveChanges();
        }

        public ICollection<User> GetAll()
        {
            return _dbContext.Users.ToList();
        }

        public User GetById(string id)
        {
            var itemFind = _dbContext.Users.Single(item => item.Id == id);

            return itemFind;
        }

        public User Update(User entity)
        {
            var itemUpdate = _dbContext.Users.Update(entity).Entity;

            _dbContext.SaveChanges();

            return itemUpdate;
        }
    }
}
