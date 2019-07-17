using NoScope360Engine.Core.Entites.Items;

namespace NoScope360Engine.Core.Entites.Creatures
{
    /// <summary>
    /// Ammunition of a person
    /// (weapon, armor, helmet and etc.)
    /// </summary>
    public class Ammunition
    {
        public Item Weapon { get; set; }
        public Item Armor { get; set; }
        public Item Helmet { get; set; }
        public Ammunition()
        {
        }
    }
}
