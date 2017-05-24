using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerLoader : MonoBehaviour {

    public Player player;    
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.F4))
        {
            player = PlayerLoader.Instance.LoadPlayer("DEBUGPLAYER");
            GetComponent<PlayerBehaviour>().player.Health = player.Health;
        }	
	}
}
