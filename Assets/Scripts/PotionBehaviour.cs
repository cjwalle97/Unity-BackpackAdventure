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

        // Update is called once per frame
        void Update()
        {

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
            Vector3 newScale = new Vector3(0, 0, 0);
            gameObject.transform.localScale = newScale;
            Destroy(gameObject);
        }

        public void OnDrop(Potion other)
        {
            _other = Instantiate(other);
            gameObject.transform.localScale = OriginalScale;
        }
    }
}
