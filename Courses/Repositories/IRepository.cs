using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetByID(int id);

        // Create a Record
        void Create(T obj);

        // Update a Record
        void Update(T obj);

        // Delete a Record
        void Delete(T obj);
        
    }
}
