using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Method
    {
        public string Accessor { get; set; }
        public string Name { get; set; }

        public Method(string accessor, string name)
        {
            Accessor = accessor;
            Name = name;
        }
    }
}
