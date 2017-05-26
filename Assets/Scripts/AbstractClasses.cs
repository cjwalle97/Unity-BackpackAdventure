using UnityEngine;
using System.Collections.Generic;

public abstract class Item : ScriptableObject
{
    public string Name;
}

public abstract class Armor : Equipment
{
    public int Defense;
}


public abstract class Equipment : Item
{

}


public abstract class Food : Consumable
{
    public int Recover;
}


public abstract class Weapon : Equipment
{
    public int Attack;
}

public abstract class Consumable : Item
{

}


public abstract class Potion : Consumable
{
    public int Recovery;
}


public class Book : Equipment
{
    public string SkillName;
}


public abstract class Bomb : Consumable
{
    public int Damage;
}