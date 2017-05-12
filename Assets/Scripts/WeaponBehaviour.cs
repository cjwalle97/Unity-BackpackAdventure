﻿namespace Scripts
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class WeaponBehaviour : MonoBehaviour
    {
        public Weapon WeaponConfig;
        [HideInInspector]
        public Weapon _other;

        // Use this for initialization
        void Start()
        {
            _other = Instantiate(WeaponConfig);
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