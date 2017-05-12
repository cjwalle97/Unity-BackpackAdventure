namespace Scripts
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "Bomb", menuName = "Item/Consumable/Bomb", 
        order = 0)]
    
    public class Bomb : Consumable
    {
        public int Damage;
    }
}