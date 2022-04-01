using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4API.Services
{
    public interface IInterestRepository<T>
    {
        Task<IEnumerable<T>> GetAllInterestsFromPerson(int id);
        Task<T> NewInterest(T newInterest);
    }
}
