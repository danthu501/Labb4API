using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4API.Services
{
    public interface ILinks<Link>
    {
            Task<IEnumerable<Link>> AllLinksFromOnePerson(int id);
            Task<Link> NewLink(Link newLink);
    }
}
