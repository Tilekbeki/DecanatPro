using System.Collections.Generic;

namespace DataAccessLayer
{
    public class EntityFrameworkRepository<T> : IRepository<T> where T : class
    {
        public Context context = new Context();
        public IEnumerable<T> GetAll()
        {
            return context.Set<T>();
        }
        public void Create(T t)
        {
            context.Set<T>().Add(t);
            Save();
        }
        public void Save()
        {
            context.SaveChanges();
        }
        public void Delete(int list_number)
        {
            context.Set<T>().Remove(FindForIndex(list_number));
            Save();
        }
        public T FindForIndex(int index)
        {
            T peop;
            peop = context.Set<T>().Find(index);
            return peop;
        }

    }
}
