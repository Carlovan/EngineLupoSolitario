using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameEngine
{
    class Inventory
    {
        public List<Item> Items { get; set; }

        public Inventory (List<Item> its)
        {
            Items = new List<Item>(its);
        }

        public void PopItem(int i)
        {
			Items.Remove(Items[i]);
        }

		public void PopItem(Item i)
		{
			Items.Remove(i);
		}

		public bool UseItem(Player p, int i)
		{
			if (Items[i].IsUsable)
			{
				Items[i].UseEffect(p);
				if (Items[i].Eff.IsDecade)
					PopItem(i);
				return true;
			}
			return false;
		}

		public bool UseItem(Player p, Item i)
		{
			if (i.IsUsable)
			{
				i.UseEffect(p);
				if (i.Eff.IsDecade)
					PopItem(i);
				return true;
			}
			return false;
		}
    }
}
