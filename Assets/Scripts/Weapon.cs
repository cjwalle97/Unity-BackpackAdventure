namespace Scripts
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "Weapon", menuName = "Item/Equipment/Weapon", 
        order = 0)]
    public class Weapon : Equipment
    {
        public int Attack;
    }
}