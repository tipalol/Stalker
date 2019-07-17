namespace NoScope360Engine.Core.Entites.Creatures.NPC
{
    /// <summary>
    /// Alive person, that can be stalker, bandit, player or somebody alse 
    /// </summary>
    public class Person : Creature
    {
        /// <summary>
        /// Inventory of this character
        /// </summary>
        public Inventory Inventory { get; set; }
        /// <summary>
        /// Ammunition of this character
        /// (weapon, armor, helmet and etc.)
        /// </summary>
        public Ammunition Ammunition { get; set; } = new Ammunition();
        public Person(string name = "default") : base(name)
        {
        }
    }
}
