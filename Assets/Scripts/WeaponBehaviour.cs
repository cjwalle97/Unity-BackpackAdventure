namespace Scripts
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class WeaponBehaviour : MonoBehaviour
    {
        public Weapon WeaponConfig;
        [HideInInspector]
        public Weapon _other;

        private Vector3 OriginalScale;

        // Use this for initialization
        void Start()
        {
            _other = Instantiate(WeaponConfig);
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

        public void OnDrop(Weapon other)
        {
            WeaponConfig = other;
            _other = Instantiate(WeaponConfig);
        }
    }
}