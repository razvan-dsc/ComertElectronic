using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectWAD.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(int id);
        ICollection<T> GetAll();
        T Add(T entity);  
        T Update(T entity);
        void Delete(int id);

    }
}
