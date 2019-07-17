using System.Collections.Generic;
using NoScope360Engine.Core.Entites.Creatures;

namespace NoScope360Engine.Core.Entites.Buildings
{
    /// <summary>
    /// Some building placed in <see cref="Locations.Location"/>
    /// </summary>
    public class Building : GameObject
    {
        /// <summary>
        /// Coordinates of this building
        /// (coordinates of building's population should be same)
        /// </summary>
        public (int x, int y) Coordinates { get; set; }
        /// <summary>
        /// List of all creatures inside this building
        /// </summary>
        public List<Creature> Population { get; set; } = new List<Creature>();
        public Building(string name = "default building") : base(name)
        {
        }
    }
}
