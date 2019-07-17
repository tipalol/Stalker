namespace NoScope360Engine.Core.Entites.Items
{
    /// <summary>
    /// Ammo
    /// (it is type of ammo for weapon and it's ammo capacity,
    /// or ammo in somebody's inventory)
    /// </summary>
    public class Ammo : Item
    {
        /// <summary>
        /// Count of ammo in inventory or in weapon
        /// </summary>
        public int Count { get; set; }
        public Ammo(string name = "default ammo") : base(name)
        {
        }
    }
}
