
using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "BackPack")]
public class Backpack : ScriptableObject
{
    public string BackpackName;
    public List<Item> Items;
}
