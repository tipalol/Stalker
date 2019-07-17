namespace NoScope360Engine.Core.Entites.Items
{
    /// <summary>
    /// <see cref="Item"/> \/(0_0)\/
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Name of a Item
        /// </summary>
        public string Name { get; set; }
        public Item(string name = "default") 
        {
            Name = name;
        }
    }
}
