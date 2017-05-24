using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

    public Player player;
    public float PlayerHealth;
    
    // Update is called once per frame
    void Update () {
                
        PlayerHealth = player.Health;

	}
}
