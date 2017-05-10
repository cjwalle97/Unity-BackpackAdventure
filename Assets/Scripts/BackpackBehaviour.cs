using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpackBehaviour : MonoBehaviour {

    private Dictionary<string, List<GameObject>> _backpack;

	// Use this for initialization
	void Start () {
        
        _backpack = new Dictionary<string, List<GameObject>>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
