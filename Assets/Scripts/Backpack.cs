namespace Scripts
{
    using UnityEngine;
    using System.Collections.Generic;

    [CreateAssetMenu(fileName = "Backpack", menuName = "Item/Permanent/Backpack", order = 0)]
    public class Backpack : ScriptableObject
    {
        public string BackpackName;
        public List<Item> Items;
    }

}