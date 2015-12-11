using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameEngine
{
    /// <summary>
    /// This is the class used for the Items in an Inventory
    /// </summary>
    class Item
    {
        /// <summary>
        /// Name of the item
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// If the Item is a weapon
        /// </summary>
        public bool IsWeapon { get; set; }

        /// <summary>
        /// If a Item is usable
        /// </summary>
        public bool IsUsable { get; set; }

        /// <summary>
        /// The Effect of the Item
        /// </summary>
        public Effect Eff { get; set; }

        /// <summary>
        /// Constructor for a simple item
        /// </summary>
        /// <param name="n">Name of the Item</param>
		public Item(string n)
		{
			Name = n;
            IsWeapon = false;
            IsUsable = false;
            Eff = null;
		}

        /// <summary>
        /// Constructor for a weapon
        /// </summary>
        /// <param name="n">Name of the weapon</param>
        /// <param name="w">Set this to true</param>
		public Item(string n, bool w)
		{
			Name = n;
			IsWeapon = w;
            IsUsable = false;
            Eff = null;
		}

        /// <summary>
        /// Constructor for a weapon with an Effect
        /// </summary>
        /// <param name="n">Name of the weapon</param>
        /// <param name="w">Set this to true</param>
        /// <param name="e">Effect of the weapon</param>
        public Item(string n, bool w, Effect e)
        {
            Name = n;
            IsWeapon = w;
            IsUsable = false;
            Eff = e;
        }

        /// <summary>
        /// Constructor for a complex item
        /// </summary>
        /// <param name="n">Name of the Item</param>
        /// <param name="u">Set this to true</param>
        /// <param name="e">Effect of the Item</param>
        public Item (string n, bool u, Effect e)
        {
            Name = n;
            IsWeapon = false;
            IsUsable = u;
            Eff = e;
        }

        /// <summary>
        /// A metod to use an effect on a Player
        /// </summary>
        /// <param name="p">Player on witch use the Effect</param>
        /// <returns>True if done correctly, false if not</returns>
        public bool UseEffect(Player p)
        {
            if (IsUsable)
            {
                if (Eff.Type == EffectType.AtkBuff)
                {
                    p.Atk += Eff.Size;
                }
                if (Eff.Type == EffectType.HealthBuff)
                {
                    p.MaxHealth += Eff.Size;
                    p.Heal(Eff.Size);
                }
                if (Eff.Type == EffectType.RestoreHealth)
                {
                    p.Heal(Eff.Size);
                }
                return true;
            }
            else
                return false;
        }
    }
}
