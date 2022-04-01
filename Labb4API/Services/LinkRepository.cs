using Labb4API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4API.Services
{
    public class LinkRepository : ILinks<Link>
    {
        private Labb4APIDbContext _Labb4APIDbContext;
        public LinkRepository(Labb4APIDbContext labb4APIDbContext)
        {
            _Labb4APIDbContext = labb4APIDbContext;
        }
        public async Task<IEnumerable<Link>> AllLinksFromOnePerson(int id)
        {
            var result = from Link in _Labb4APIDbContext.Links
                         where Link.PersonId == id
                         select Link;

            return result.Include(L => L.People); /*.ThenInclude(I => I.Interests);*/
        }

        public async Task<Link> NewLink(Link newLink)
        {
            var result = await _Labb4APIDbContext.Links.AddAsync(newLink);
            await _Labb4APIDbContext.SaveChangesAsync();
            return result.Entity;
        }
    }
}
