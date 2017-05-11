namespace Scripts
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class FoodBehaviour : MonoBehaviour
    {
        public Food FoodConfig;
        [HideInInspector]
        public Food _other;

        // Use this for initialization
        void Start()
        {
            _other = Instantiate(FoodConfig);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
