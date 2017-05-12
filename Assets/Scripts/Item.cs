namespace Scripts
{
    using UnityEngine;

    public enum ItemType
    {
        Consumable = 0,

        Equipment = 1,
    }

    public abstract class Item : ScriptableObject
    {
        public string Name;
        public ItemType Type;
    }
}
