using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class MovieCast
    {
        public int MovieId { get; set; }
        public Movie movie { get; set; }
        public int CastId { get; set; }
        public Cast cast { get; set; }
        [Key]
        public string Character { get; set; }

    }
}
