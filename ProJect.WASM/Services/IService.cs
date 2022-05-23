using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProJect.WASM.Services
{
    public interface IService<T>
    {
       Task< List<T>> getAll();
       Task< T> getById(int id);
        Task insert ( T item);
        Task Update(int id, T item);

        Task delete(int id);

    }
}
