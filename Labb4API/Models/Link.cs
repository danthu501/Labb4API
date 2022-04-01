using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4API.Models
{
    public class Link
    {
        [Key]
        public string LinksId { get; set; }
        public string LinkAdress { get; set; }

        public int PersonId { get; set; }
        public People People { get; set; }

        public int InterestId { get; set; }
        public Interest Interest { get; set; }


    }
}
