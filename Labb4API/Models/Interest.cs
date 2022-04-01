using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4API.Models
{
    public class Interest
    {
        [Key]
        public int IntrestId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PeopleId { get; set; }
        public People People { get; set; }
        public List<Link> Links { get; set; }
    }
}
