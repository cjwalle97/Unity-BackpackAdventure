using System;
using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "BackPack"), Serializable]
public class Backpack : ScriptableObject
{
    public string BackpackName;    
    public List<Item> Items;
}
