using System.Collections.Generic;
using NoScope360Engine.Core.Entites.Buildings;

namespace NoScope360Engine.Core.Entites.Locations
{
    public class Location
    {
        public string Name { get; set; }
        /// <summary>
        /// Ways to walk from this <see cref="Location"/>
        /// </summary>
        public List<Location> Pathes { get; set; }
        public List<Building> Buildings { get; set; } = new List<Building>();
        
        public Location(string name = "default")
        {
            Name = name;
        }
    }
}
