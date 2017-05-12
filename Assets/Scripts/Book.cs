namespace Scripts{

    using UnityEngine;

    [CreateAssetMenu(fileName = "Book", menuName = "Item/Equipment/Book",
        order = 0)]
    public abstract class Book : Equipment {
        public string SkillName;
    }
}