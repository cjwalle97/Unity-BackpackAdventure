namespace Scripts
{
    using UnityEngine;
    using System.Collections.Generic;

    [CreateAssetMenu(fileName = "Backpack", menuName = "Item/Equipment/Backpack", order = 0)]
    public abstract class Backpack : Equipment
    {
        public string BackpackName;
        public List<Item> Items;
    }

}