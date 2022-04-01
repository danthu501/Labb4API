using Labb4API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4API.Services
{
    public class IntrestRepository : IInterestRepository<Interest>
    {

        private Labb4APIDbContext _Labb4APIDbContext;
        public IntrestRepository(Labb4APIDbContext labb4APIDbContext)
        {
            _Labb4APIDbContext = labb4APIDbContext;
        }
        public async Task<IEnumerable<Interest>> GetAllInterestsFromPerson(int id)
        {
            var result = from Interest in _Labb4APIDbContext.Interests
                         where Interest.People.Id == id
                         select Interest;

            return result;
        }
        
        public async Task<Interest> NewInterest(Interest newInterest)
        {
            var result = await _Labb4APIDbContext.Interests.AddAsync(newInterest);
            
            await _Labb4APIDbContext.SaveChangesAsync();
            return result.Entity;
        }


    }
}
