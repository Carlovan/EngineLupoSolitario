using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameEngine
{
    /// <summary>
    /// This is the class used for the Ramas' Arts of a player
    /// </summary>
    class RamasArt
    {
        /// <summary>
        /// A enumeration used for the name of an art
        /// </summary>
        public ArtName Name { get; set; }

        /// <summary>
        /// Since the Scherma Art requires to specify a weapon, this is the proprety used for that
        /// </summary>
        public string WeaponScherma { get; set; }

        /// <summary>
        /// Constructor for the class (no Scherma)
        /// </summary>
        /// <param name="n">Art's Name</param>
        public RamasArt(ArtName n)
        {
            Name = n;
            WeaponScherma = null;
        }

        /// <summary>
        /// Constructor for the class (used for Scherma's Art)
        /// </summary>
        /// <param name="a">Name of the weapon</param>
        public RamasArt (string a)
        {
            Name = ArtName.Scherma;
            WeaponScherma = a;
        }
    }
}
