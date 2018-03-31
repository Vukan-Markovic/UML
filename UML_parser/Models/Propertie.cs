using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Propertie
    {
        public string Accessor { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Propertie(string accessor, string name, string type)
        {
            Accessor = accessor;
            Name = name;
            Type = type;
        }
    }
}
