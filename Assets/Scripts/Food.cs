namespace Scripts
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "Food", menuName = "Item/Consumable/Food",
        order = 0)]

    public abstract class Food : Consumable
    {
        public int Recover;
    }
}
