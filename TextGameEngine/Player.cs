using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameEngine
{
    class Player
    {
        public string Name { get; set; }

        public int Atk { get; set; }

        public int Health { get; set; }

        public int MaxHealth { get; set; }

		public bool HasNoWeapon { get; private set; }

        public List<ArteRamas> ArtiRamas { get; set; }

        public Inventory Inv { get; set; }

        public Player (string n, int a, int h, List<ArteRamas> ar, Inventory i)
        {
            Name = n;
            Atk = a;
            Health = h;
            MaxHealth = h;
			HasNoWeapon = false;
			ArtiRamas = new List<ArteRamas>(ar);
            Inv = i;
        }

        public void Heal(int h)
        {
            Health += h;
            if (Health > MaxHealth)
                Health = MaxHealth;
        }

		public bool Hurt(int d)
		{
			if (d >= Health)
				return false;
			else
				Health -= d;
			return true;
		}

		public void CheckState()
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
