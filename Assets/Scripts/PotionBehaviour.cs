namespace Scripts
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class PotionBehaviour : MonoBehaviour
    {
        public Potion PotionConfig;
        [HideInInspector]
        public Potion _other;

        private Vector3 OriginalScale;

        // Use this for initialization
        void Start()
        {
            _other = Instantiate(PotionConfig);
            OriginalScale = gameObject.transform.localScale;
        }
        
        private void OnTriggerEnter(Collider col)
        {
            if (col.tag == "Player")
            {
                col.GetComponentInChildren<BackpackBehaviour>().AddToBackpack(_other);
                OnPickUp();
            }
        }
        public void OnPickUp()
        {
            for(float size = 4.0f; size > 0.0f; size -= 0.1f)
            {
                gameObject.transform.localScale = new Vector3(size, size, size);
            }
            
            Destroy(gameObject, 0.5f);
        }

        public void OnDrop(Potion other)
        {
            PotionConfig = other;
            _other = Instantiate(PotionConfig);
            Debug.Log(other.name);
            //gameObject.transform.localScale = OriginalScale;
        }
    }
}
