using System;
using System.Collections;
using UnityEngine;
public class _baseitem
{
    public string Name;
    public ItemType Type;

}
public enum ItemType
{
    Consumable = 0,

    Permanent = 1,
}
