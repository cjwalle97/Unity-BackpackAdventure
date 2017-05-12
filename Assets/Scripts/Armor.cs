namespace Scripts{

    using UnityEngine;

    [CreateAssetMenu(fileName = "Armor", menuName = "Item/Equipment/Armor", 
        order = 1)]

    public abstract class Armor : Equipment {
        public int Defense;
    }
}
