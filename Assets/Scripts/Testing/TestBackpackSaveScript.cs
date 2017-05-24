using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestBackpackSaveScript : MonoBehaviour {

    public Backpack Backpack;
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.F1))
        {
            BackpackSaver.Instance.SaveBackpack(Backpack, "DEBUGBACKPACK");
        }
	}
}
