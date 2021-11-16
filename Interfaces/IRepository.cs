using System.Collections.Generic;


namespace dio_dotnet_poo.Interfaces
{
    public interface IRepository<T>
    {
        List<T> listAll();
        T getById(int id);
        void insert(T entity);
        void delete(int id);
        void update(int id, T entity);
        int nextId();
    }
}