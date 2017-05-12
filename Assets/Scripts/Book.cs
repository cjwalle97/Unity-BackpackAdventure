namespace Scripts{

    using UnityEngine;

    [CreateAssetMenu(fileName = "Book", menuName = "Item/Permanent/Book",
        order = 0)]
    public class Book : Item {
        public string SkillName;
    }
}