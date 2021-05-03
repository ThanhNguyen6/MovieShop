using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Crew
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string timdburl { get; set; }
        public string profilePath { get; set; }

    }
}
