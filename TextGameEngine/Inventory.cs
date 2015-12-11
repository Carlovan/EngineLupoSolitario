using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameEngine
{
    /// <summary>
    /// This is the class used for the Inventory of a Player or a Shop
    /// </summary>
    class Inventory
    {
        /// <summary>
        /// A list of Item witch is the Inventory itself
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// The constructor for the class (empty inventory)
        /// </summary>
        /// <param name="its"></param>
        public Inventory()
        {
            Items = new List<Item>();
        }

        /// <summary>
        /// The constructor for the class
        /// </summary>
        /// <param name="its">A list of Item</param>
        public Inventory (List<Item> its)
        {
            Items = new List<Item>(its);
        }

        /// <summary>
        /// A metod that pops an Item of the List
        /// </summary>
        /// <param name="i">Index of the Item in the List</param>
        public void PopItem(int i)
        {
			Items.Remove(Items[i]);
        }

        /// <summary>
        /// A metod that pops an Item of the List
        /// </summary>
        /// <param name="i">An Item</param>
		public void PopItem(Item i)
		{
			Items.Remove(i);
		}

        /// <summary>
        /// A metod that use an Item on a Player
        /// </summary>
        /// <param name="p">Player on witch use the effect</param>
        /// <param name="i">Index of the Item in the List</param>
        /// <returns>True if done correctly, false if not</returns>
		public bool UseItem(Player p, int i)
		{
			if (Items[i].IsUsable)
			{
				Items[i].UseEffect(p);
				if (Items[i].Eff.IsDecadable)
					PopItem(i);
				return true;
			}
			return false;
		}

        /// <summary>
        /// A metod that use an Item on a Player
        /// </summary>
        /// <param name="p">Player on witch use the effect</param>
        /// <param name="i">An Item</param>
        /// <returns>True if done correctly, false if not</returns>
		public bool UseItem(Player p, Item i)
		{
			if (i.IsUsable)
			{
				i.UseEffect(p);
				if (i.Eff.IsDecadable)
					PopItem(i);
				return true;
			}
			return false;
		}

        /// <summary>
        /// A metod that check if an Item is present in the Inventory
        /// </summary>
        /// <param name="i">An Item to search</param>
        /// <returns></returns>
        public bool IsItemPresent(Item i)
        {
            return Items.Contains(i);
        }
    }
}
