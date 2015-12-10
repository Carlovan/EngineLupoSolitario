using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameEngine
{
    class ArteRamas
    {
        public NameArte Name { get; set; }

        public string WeaponScherma { get; set; }

        public ArteRamas(NameArte n)
        {
            Name = n;
            WeaponScherma = null;
        }

        public ArteRamas (NameArte n, string a)
        {
            Name = n;
            WeaponScherma = a;
        }
    }
}
