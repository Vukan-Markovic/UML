using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Relationship
    {
        public string Type { get; set; }
        public int Cardinality { get; set; }
        public Class Class { get; set; }

        public Relationship(string type)
        {
            Type = type;
        }
    }
}
