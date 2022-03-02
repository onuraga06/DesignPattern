using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Gamings:Gaming
    {
        public override Gaming Clone()
        {
            return (Gaming)this.MemberwiseClone();
        }
    }
}
