using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Managment.Deliveries.Persistence.NewFolder
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> get(int id);
        Task<IReadOnlyList<T>> GetAll();
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
        Task<bool> Exists(int id);

    }
}
