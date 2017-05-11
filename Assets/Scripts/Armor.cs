namespace Scripts{

    using UnityEngine;

    [CreateAssetMenu(fileName = "Armor", menuName = "Item/Permanent/Armor", 
        order = 0)]

    public class Armor : Item {
        public int Defense;
    }
}
