using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameEngine
{
    /// <summary>
    /// This is the class used for the Players
    /// </summary>
    class Player
    {
        /// <summary>
        /// Name of the Player
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Attack of the Player
        /// </summary>
        public int Atk { get; set; }

        /// <summary>
        /// Current Health of the Player
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// MaxHealth of the Player
        /// </summary>
        public int MaxHealth { get; set; }

        /// <summary>
        /// If the Player has no weapon
        /// </summary>
		public bool HasNoWeapon { get; private set; }

        /// <summary>
        /// Ramas Arts of the Player
        /// </summary>
        public List<RamasArt> RamasArts { get; set; }

        /// <summary>
        /// Inventory of the Player
        /// </summary>
        public Inventory Inv { get; set; }

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="n">Name of the Player</param>
        /// <param name="a">Attack of the Player</param>
        /// <param name="h">Health of the Player</param>
        /// <param name="ar">Ramas Arts of the Player</param>
        /// <param name="i">Inventory of the Player</param>
        public Player (string n, int a, int h, List<RamasArt> ar, Inventory i)
        {
            Name = n;
            Atk = a;
            Health = h;
            MaxHealth = h;
			HasNoWeapon = false;
			RamasArts = new List<RamasArt>(ar);
            Inv = i;
        }

        /// <summary>
        /// A metod to Heal the Player
        /// </summary>
        /// <param name="h">Amount of the Heal</param>
        public void Heal(int h)
        {
            Health += h;
            if (Health > MaxHealth)
                Health = MaxHealth;
        }

        /// <summary>
        /// A metod to Hurt the Player
        /// </summary>
        /// <param name="d">Amount of the Hurt</param>
        /// <returns>If the Player is dead returns false, if not true</returns>
		public bool Hurt(int d)
		{
			if (d >= Health)
				return false;
			else
				Health -= d;
			return true;
		}

        /// <summary>
        /// A metod that check if the Player has the weapon and resize its attack.
        /// It replaces the lack of an event that triggers every time the last weapon is removed or the first weapon is inserted.
        /// IMPORTANT : It should be used every time an operation on the Inventory is done.
        /// </summary>
		public void CheckWeaponState()
		{
			if (HasNoWeapon)
			{
				for (int i = 0; i < Inv.Items.Count; i++)
				{
					if (Inv.Items[i].IsWeapon)
						HasNoWeapon = false;
				}
				if (!HasNoWeapon)
					Atk += 2;
			}
			else
			{
				HasNoWeapon = true;
				for (int i = 0; i < Inv.Items.Count; i++)
				{
					if (Inv.Items[i].IsWeapon)
						HasNoWeapon = false;
				}
				if (HasNoWeapon)
					Atk -= 2;
			}	
		}
    }
}
