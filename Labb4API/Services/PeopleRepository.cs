using Labb4API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Labb4API.Services
{
    public class PeopleRepository : ILabb4API<People>
    {
        private Labb4APIDbContext _Labb4APIDbContext;
        public PeopleRepository(Labb4APIDbContext labb4APIDbContext)
        {
            _Labb4APIDbContext = labb4APIDbContext;
        }

        public Task<People> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<People>> GetAll()
        {
            //var result = await (from People in _Labb4APIDbContext.Peoples
            //                   join Link in _Labb4APIDbContext.Links on People.Id equals Link.PersonId
            //                   join Interest in _Labb4APIDbContext.Interests on Link.InterestId equals Interest.IntrestId
            //                   select People).ToListAsync();
            return await _Labb4APIDbContext.Peoples.ToListAsync();/*Include(i => i.Interests).ToListAsync();*/
        }

        public Task<People> GetSingel(int id)
        {
            throw new NotImplementedException();
        }

        public Task<People> Update(People newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
