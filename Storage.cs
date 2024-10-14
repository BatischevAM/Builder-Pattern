using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
    public class Storage
    {
        public string Type { get; set; } 
        public string Size { get; set; }

        public override string ToString()
        {
            return $"{Size} {Type}";
        }
    }
}
