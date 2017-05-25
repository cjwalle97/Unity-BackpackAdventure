using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class PlayerBehaviour : MonoBehaviour
    {

        public Player player;
        public float PlayerHealth;

        public Backpack _backpack;

        void Start()
        {
            _backpack = ScriptableObject.CreateInstance<Backpack>();
        }

        // Update is called once per frame
        void Update()
        {
            PlayerHealth = player.Health;
            _backpack = GetComponentInChildren<BackpackBehaviour>().Pack;

            if (Input.GetKeyDown(KeyCode.F1))
            {
                BackpackSaver.Instance.SaveBackpack(_backpack, player.Name);
            }

            if (Input.GetKeyDown(KeyCode.F2))
            {
                GetComponentInChildren<BackpackBehaviour>().Pack = BackpackLoader.Instance.LoadBackpack("DEBUG");
                _backpack = GetComponentInChildren<BackpackBehaviour>().Pack;
                //Items = _backpack.Items;
                //_backpack.Items.ForEach(x => { x = Instantiate(x); });              
            }

        }
    }
}