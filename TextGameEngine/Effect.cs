using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameEngine
{
    class Effect
    {
        public EffectType Type {get; set;}

        public int Size { get; set; }

        public bool IsDecade { get; set; }

        public Effect (EffectType e, int s, bool d)
        {
            Type = e;
            Size = s;
            IsDecade = d;
        }
    }
}
