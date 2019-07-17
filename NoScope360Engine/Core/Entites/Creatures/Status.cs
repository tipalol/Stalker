namespace NoScope360Engine.Core.Entites.Creatures
{
    /// <summary>
    /// Aim of somebody(ies)
    /// </summary>
    public enum Status
    {
        Relaxing,       //Doing nothing, just relaxing
        Patrolling,     //Patrol the area, attack enemies near it's coordinates
        Expance,        //It means, that now it wants to capture some point (building)
        Attack          //Now it attacks or go to attack somebody's location
    }
}
