namespace Scripts
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "Weapon", menuName = "Item/Permanent/Weapon", 
        order = 0)]
    public class Weapon : Item
    {
        public int Attack;
    }
}