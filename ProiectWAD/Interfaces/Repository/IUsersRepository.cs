using ProiectWAD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectWAD.Interfaces.Repository
{
    public interface IUsersRepository
    {
        User GetById(string id);
        ICollection<User> GetAll();
        User Add(User entity);
        User Update(User entity);
        void Delete(string id);

    }
}
