﻿namespace Scripts
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class ArmorBehaviour : MonoBehaviour
    {
        public Armor ArmorConfig;
        [HideInInspector]
        public Armor _other;

        private Vector3 OriginalScale;

        // Use this for initialization
        void Start()
        {
            _other = Instantiate(ArmorConfig) as Armor;
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

        public void OnDrop(Armor other)
        {
            ArmorConfig = other;
            _other = Instantiate(ArmorConfig) as Armor;
        }
        
    }
}