using System.Collections.Generic;
namespace NoScope360Engine.Core.Entites
{
    /// <summary>
    /// Base class
    /// </summary>
    public abstract class GameObject
    {
        private static List<GameObject> Objects { get; set; } = new List<GameObject>();
        /// <summary>
        /// Get game object by Id
        /// </summary>
        /// <param name="Id">Game object</param>
        /// <returns></returns>
        public static GameObject GetObject(int Id) => Objects.Find((GameObject obj) => obj.Id == Id);
        /// <summary>
        /// Get game object by name
        /// </summary>
        /// <param name="Name">Game object</param>
        /// <returns></returns>
        public static GameObject GetObject(string Name) => Objects.Find((GameObject obj) => obj.Name == Name);
        private int Id { get; set; }
        /// <summary>
        /// Object's name
        /// </summary>
        private string Name { get; set; }
        public GameObject(string name = "default")
        {
            Id = Objects.Count;
            Name = name;
            Objects.Add(this);
        }
    }
}
