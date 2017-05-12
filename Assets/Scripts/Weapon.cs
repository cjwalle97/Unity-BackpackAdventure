namespace Scripts
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "Weapon", menuName = "Item/Equipment/Weapon", 
        order = 0)]
    public abstract class Weapon : Equipment
    {
        public int Attack;
    }
}