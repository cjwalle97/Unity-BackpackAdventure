using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

[CreateAssetMenu(fileName ="LootTable")]
public class LootTable : ScriptableObject
{
    /*Assignment
    Theme: How to Contribute!
    Contributions to repositories increase professional value.
    
    1. Create a Loot Table
    precondition: Must have List of Item
    postcondition: Returns a List of Item with respect to random roll
    
    Specifications
    a. Scriptable Object to be created per designer specifications
    b. List of Item types to populate with
    c. Chance for each item.
    d. GetDrops method to return all drops on resolution */

    [System.Serializable]
    public class ItemDrop {
        public Item item;
        [Range(0,1)]
        public float chance;
    }
    public List<ItemDrop> Drops;
     
    public float randRoll;

    public List<Item> GetDrops()
    {
        List<Item> items = new List<Item>();
        
        //GET RANDOM ROLL
        randRoll = Random.Range(0f, 1f);

        //COMPARE EACH ITEMDROP CHANCE TO 'RANDROLL'
        Drops.ForEach(x => { if (x.chance > randRoll) { items.Add(x.item); } });
        
        //RETURN ITEMS
        return items;
    }


#if UNITY_EDITOR
    [CustomEditor(typeof(LootTable))]
    public class InspectorLootTable : Editor {

        GUIStyle Header = new GUIStyle();

        public List<Item> Items = new List<Item>();
        string _items = "";

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            var mytarget = target as LootTable;

            Header.alignment = TextAnchor.MiddleCenter;
            Header.fontSize = 20;
            Header.normal.textColor = Color.white;
            GUILayout.Space(20);
            
            GUILayout.Label("Loot Table", Header);
            GUILayout.Space(20);
            
            if (GUILayout.Button("Get Drops")) {

                Items = mytarget.GetDrops();                
                Items.ForEach(x => { _items += x.Name + "\n"; });                
            }

            if (GUILayout.Button("Clear")) { _items = ""; }
            
            GUILayout.Box("Items Dropped: \n" + _items);

            GUILayout.Space(30);

        }


    }
#endif
}



