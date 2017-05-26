using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class PlayerBehaviour : MonoBehaviour
    {

        public Player player;
        public Backpack _backpack;

        void Start()
        {
            _backpack = ScriptableObject.CreateInstance<Backpack>();
        }

        // Update is called once per frame
        void Update()
        {
            _backpack = GetComponentInChildren<BackpackBehaviour>().Pack;

            if (Input.GetKeyDown(KeyCode.F1))
            {
                BackpackSaver.Instance.SaveBackpack(_backpack, "BackpackSave");
            }

            if (Input.GetKeyDown(KeyCode.F2))
            {
                GetComponentInChildren<BackpackBehaviour>().Pack = BackpackLoader.Instance.LoadBackpack("BackpackSave");
                _backpack = GetComponentInChildren<BackpackBehaviour>().Pack;              
            }
        }
    }
}