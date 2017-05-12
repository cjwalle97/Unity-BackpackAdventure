namespace Scripts
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "Bomb", menuName = "Item/Consumable/Bomb", 
        order = 0)]
    
    public class Bomb : Item
    {
        public int Damage;
    }
}