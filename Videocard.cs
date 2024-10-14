using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
    public class Videocard
    {
        public string Model { get; set; }

        public override string ToString()
        {
            return Model;
        }
    }
}
