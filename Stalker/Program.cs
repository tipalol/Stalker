using NoScope360Engine.Core.Entites.Creatures;
using NoScope360Engine.Core.Entites.Creatures.NPC;
using NoScope360Engine.Core.Entites.Items;
using NoScope360Engine.Core.Entites.Locations;
using NoScope360Engine.Core.Entites.Buildings;

namespace StalkerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating new stalker at point {8;10}
            Stalker stalker = new Stalker("Борода") { Coordinates = (8, 10) };
            //Creating weapon for him (maybe i've made mistake with ammo name for PM, but nobody cares XD)
            Weapon weapon = new Weapon("PM") { Damage = 2, Ammo = new Ammo("9x86") { Count = 8 } };
            //Creating ammo for PM
            Ammo ammo = new Ammo("9x86") { Count = 24 };
            //Creating inventory for stalker
            Inventory inventory = new Inventory();
            inventory.Items.Add(ammo);
            //Adding inventory to stalker
            stalker.Inventory = inventory;
            //Giving weapon to stalker
            stalker.Ammunition.Weapon = weapon;

            //Creating perfect location for this awesome stalker
            Location location = new Location("Skadovsk");
            //Creating ideal place where our stalker will live
            Building building = new Building("Skadovsk") { Coordinates = (8, 10) };
            //Put oue stalker into new building
            building.Population.Add(stalker);
            //Adding building to location
            location.Buildings.Add(building);

            //Now we have location Skadovsk with building Skadovsk inside,
            //where lives stalker Boroda who haves PM and 24 ammo for it

        }
    }
}
