using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4API.Models
{
    public class Interest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Link> Links { get; set; }
    }
}
