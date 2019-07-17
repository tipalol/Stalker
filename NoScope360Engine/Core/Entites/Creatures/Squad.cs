using System.Collections.Generic;

namespace NoScope360Engine.Core.Entites.Creatures
{
    /// <summary>
    /// Group of creatures having the same aim
    /// (status): attacking, patrolling,
    /// expansing and etc.
    /// </summary>
    public class Squad
    {
        /// <summary>
        /// List of creatures of this <see cref="Squad"/>
        /// </summary>
        public List<Creature> Creatures { get; set; }
        /// <summary>
        /// Aim of this <see cref="Squad"/> for now
        /// </summary>
        public Status Status { get; set; }
        
        public Squad()
        {
        }
    }
}
