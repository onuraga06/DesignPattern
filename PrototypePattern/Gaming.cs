using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
   abstract class Gaming
    {
        public string Name { get; set; }
        public decimal Size { get; set; }
        public string  Tur { get; set; }
        public List<string> Katılımcılar { get; set; }
        public List<string> Materials { get; set; }
        public object Summary { get; set; }

        public abstract Gaming Clone();
    }
}
