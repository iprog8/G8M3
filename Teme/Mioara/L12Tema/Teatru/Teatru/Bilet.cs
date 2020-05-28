using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatru
{
    class Bilet
    {
        public string Piesa { get; set; }
        public string Loc { get; set; }
        public int PretBilet { get; set; }
        public bool Vandut { get; set; }

    }
}
