using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameEngine
{
    class Item
    {
        public string Name { get; set; }

        public bool IsWeapon { get; set; }

        public bool IsUsable { get; set; }

        public Effect Eff { get; set; }

		public Item(string n)
		{
			Name = n;
		}

		public Item(string n, bool w)
		{
			Name = n;
			IsWeapon = w;
		}

        public Item (string n, bool w, bool u, Effect e)
        {
            Name = n;
            IsWeapon = w;
            IsUsable = u;
            Eff = e;
        }

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
