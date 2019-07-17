namespace NoScope360Engine.Core.Entites.Creatures
{
    /// <summary>
    /// Some alive creature
    /// </summary>
    public class Creature : GameObject
    {
        /// <summary>
        /// Coordinates of this creature on the Location's map
        /// </summary>
        public (int x, int y) Coordinates { get; set; }
        public Creature(string name = "default") : base(name) { }
    }
}
