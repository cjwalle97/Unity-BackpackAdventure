namespace Scripts{

    using UnityEngine;

    [CreateAssetMenu(fileName = "Armor", menuName = "Item/Equipment/Armor", 
        order = 1)]

    public class Armor : Equipment {
        public int Defense;
    }
}
