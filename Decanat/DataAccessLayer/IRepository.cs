using System.Collections.Generic;
namespace DataAccessLayer
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Create(T t);
        void Save();
        void Delete(int list_number);
        T FindForIndex(int index);
    }
}
