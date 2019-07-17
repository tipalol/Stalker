namespace NoScope360Engine.Core.Entites.Creatures.NPC
{
    /// <summary>
    /// <see cref="Stalker"/>
    /// </summary>
    public class Stalker : Person, ILifeSimulated
    {
        public void Go()
        {

        }
        public Stalker(string name = "default") : base(name)
        {
        }
    }
}
