using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4API.Models
{
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<Interest> Interests { get; set; }
        public List<Link> Links { get; set; }
    }
}
