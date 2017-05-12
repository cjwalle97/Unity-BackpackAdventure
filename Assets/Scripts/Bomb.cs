namespace Scripts
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "Bomb", menuName = "Item/Consumable/Bomb", 
        order = 0)]
    
    public abstract class Bomb : Consumable
    {
        public int Damage;
    }
}