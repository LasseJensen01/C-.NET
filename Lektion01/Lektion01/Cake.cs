using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion01
{
    internal class Cake
    {
        public string CakeName { get; set; }
        public string type { get; set; }
        public string filling { get; set; }

        public Cake(string name, string type, string filling) {
            CakeName = name;
            this.type = type;
            this.filling = filling;
        }

        public override string ToString()
        {
            return CakeName + " is a " + type + " with a " + filling + " filling";
        }
    }
}
