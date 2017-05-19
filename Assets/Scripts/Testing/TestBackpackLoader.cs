using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBackpackLoader : MonoBehaviour {

    public Backpack backpack;
	
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.F2))
        {
            backpack = BackpackLoader.Instance.LoadBackpack("DEBUGBACKPACK");
        }	
	}
}
