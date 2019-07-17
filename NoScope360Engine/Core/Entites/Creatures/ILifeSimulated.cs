namespace NoScope360Engine.Core.Entites.Creatures
{
    /// <summary>
    /// Inherit this if creature is simulatable in the game
    /// (it means that these creatures live their own live
    /// without player)
    /// </summary>
    public interface ILifeSimulated
    {
        public void Go();
    }
}
