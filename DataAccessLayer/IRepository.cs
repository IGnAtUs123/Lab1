using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface IRepository<T>
    {
        void Create(T entity);
        IEnumerable<T> ReadAll();
        T ReadById(string id);
        void Update(T entity);
        void Delete(string id);
    }

}
