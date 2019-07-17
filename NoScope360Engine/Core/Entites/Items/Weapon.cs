namespace NoScope360Engine.Core.Entites.Items
{
    /// <summary>
    /// Weapon of a person (AK-47 and so on)
    /// </summary>
    public class Weapon : Item
    {
        public int Damage { get; set; }
        public Ammo Ammo { get; set; }

        public Weapon(string name = "default weapon") : base(name)
        {
        }
    }
}
