namespace Scripts
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "Potion", menuName = "Item/Consumable/Potion",
        order = 0)]

    public abstract class Potion : Consumable
    {
        public int Recovery;
    }
}
