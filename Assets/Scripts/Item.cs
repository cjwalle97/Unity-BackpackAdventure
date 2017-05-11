namespace Scripts
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "Item", menuName = "Item", order = 1)]

    public class Item : ScriptableObject
    {
        public string Name;
        public ItemType Type;

    }
    public enum ItemType
    {
        Consumable = 0,

        Permanent = 1,
    }
}
