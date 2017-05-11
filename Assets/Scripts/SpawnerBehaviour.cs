using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour {

    public GameObject Prefab;
    [HideInInspector]
    public GameObject _other;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            _other = Instantiate(Prefab, transform.position,transform.rotation);
        }
	}
}
