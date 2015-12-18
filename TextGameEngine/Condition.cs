using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameEngine
{
    class Condition
    {
        public ArtName[] Arts { get; private set; }

        public Item[] Items { get; private set; }

        public int Health { get; private set; }

        public int Attack { get; private set; }

        public bool Above { get; private set; }

        public Condition(ArtName[] a)
        {
            Arts = (ArtName[])a.Clone();
            Items = null;
            Health = 0;
            Attack = 0;
            Above = false;
        }

        public Condition(Item[] i)
        {
            Items = (Item[])i.Clone();
            Arts = null;
            Health = 0;
            Attack = 0;
            Above = false;
        }

        public Condition(int size, bool hoa, bool ab)
        {
            if (hoa)
                Health = size;
            else
                Attack = size;
            Above = ab;
            Arts = null;
            Items = null;
        }

        public bool IsVerified(Player p)
        {
            if (Arts != null)
            {
                for (int i = 0; i < Arts.Length; i++)
                {
                    bool ok = false;
                    for (int j = 0; j < p.RamasArts.Count; j++)
                        if (p.RamasArts[j].Name == Arts[i])
                        {
                            ok = true;
                            break;
                        }
                    if (!ok)
                        return false;
                }
            }
            else if (Items != null)
            {
                for (int i = 0; i < Items.Length; i++)
                {
                    if (!p.Inv.IsItemPresent(Items[i]))
                        return false;
                }
            }
            else if(Health != 0)
            {
                if (Above)
                {
                    if (!(p.Health >= Health))
                        return false;
                }
                else
                {
                    if (!(p.Health <= Health))
                        return false;
                }
            }
            else if(Attack != 0)
            {
                if (Above)
                {
                    if (!(p.Atk>= Attack))
                        return false;
                }
                else
                {
                    if (!(p.Atk <= Attack))
                        return false;
                }
            }
            return true;
        }
    }
}
