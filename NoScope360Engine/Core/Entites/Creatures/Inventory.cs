using NoScope360Engine.Core.Entites.Items;
using System.Collections.Generic;

namespace NoScope360Engine.Core.Entites.Creatures
{
    /// <summary>
    /// Inventory of a <see cref="Creature"/>
    /// </summary>
    public class Inventory
    {
        /// <summary>
        /// List of Items of this <see cref="Creature"/>
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();
        public Inventory()
        {
        }
    }
}
