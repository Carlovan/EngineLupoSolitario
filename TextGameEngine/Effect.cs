using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameEngine
{
    /// <summary>
    /// This is the class used for the Effect of an Item
    /// </summary>
    class Effect
    {
        /// <summary>
        /// An enumeration used for the type of effects
        /// </summary>
        public EffectType Type {get; set;}

        /// <summary>
        /// The value of the effect
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// If the effect is permanent or decadable
        /// </summary>
        public bool IsDecadable { get; set; }

        /// <summary>
        /// The constructor for the class
        /// </summary>
        /// <param name="e">EffectType</param>
        /// <param name="s">Size</param>
        /// <param name="d">IsDecadable</param>
        public Effect (EffectType e, int s, bool d)
        {
            Type = e;
            Size = s;
            IsDecadable = d;
        }
    }
}
