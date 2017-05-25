using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class TestBackpackSaveScript : MonoBehaviour
    {

        public Backpack Backpack;

        // Update is called once per frame
        void Update()
        {
            Backpack.Items.AddRange(GetComponentInChildren<BackpackBehaviour>().Items);

            if (Input.GetKeyDown(KeyCode.F1))
            {
                Debug.Log("FI KEY PRESSED");
                BackpackSaver.Instance.SaveBackpack(Backpack, "DEBUGBACKPACK");
            }
        }
    }
}