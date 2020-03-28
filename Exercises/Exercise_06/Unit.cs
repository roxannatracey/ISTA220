using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Unit
    {
        public string UnitName { get; set; }
        public string UnitSymbol { get; set; }
        public int Size { get; set; }

        public string FormatMe()
        {
            return string.Format("{0} - {1} - {2}",
                this.UnitName,
                this.UnitSymbol,
                this.Size);
        }


    }
}
