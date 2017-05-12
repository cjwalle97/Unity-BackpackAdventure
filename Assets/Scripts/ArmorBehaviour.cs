namespace Scripts
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class ArmorBehaviour : MonoBehaviour
    {
        public Armor ArmorConfig;
        [HideInInspector]
        public Armor _other;

        // Use this for initialization
        void Start()
        {
            _other = Instantiate(ArmorConfig);
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
                Destroy(gameObject);
            }
        }
    }
}