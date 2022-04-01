using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4API.Services
{
    public interface ILabb4API<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetSingel(int id);
        Task<T> Update(T newEntity);
        Task<T> Delete(int id);
    }
}
