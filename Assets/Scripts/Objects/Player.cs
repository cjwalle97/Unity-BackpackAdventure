using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player")]
public class Player : ScriptableObject
{
    public string Name;
    public float Health;
    public float Mana;
}