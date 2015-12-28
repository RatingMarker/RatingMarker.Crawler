using System.Collections.Generic;

namespace RatingMarker.Crawler.Data.Infrastructure
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Add(T entity);
        bool Update(T entity);
        bool Delete(int id);
    }
}