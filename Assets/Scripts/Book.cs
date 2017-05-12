namespace Scripts{

    using UnityEngine;

    [CreateAssetMenu(fileName = "Book", menuName = "Item/Equipment/Book",
        order = 0)]
    public class Book : Equipment {
        public string SkillName;
    }
}