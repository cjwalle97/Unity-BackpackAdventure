using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq.Expressions;
using JetBrains.Annotations;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Assets.Editor
{
    public class ItemRandomizerEditorScript : EditorWindow
    {
        private UnityEngine.Object[] items;
        private Item _item;
        private GUIStyle _header = new GUIStyle();
        private List<Item> _itemList = new List<Item>();
        private bool DisplayText;

        [MenuItem("Tools/ItemRandomizer")]
        static void Init()
        {
            var window = EditorWindow.GetWindow(typeof(ItemRandomizerEditorScript)) as ItemRandomizerEditorScript;
            if (window == null) return;
            window._item = CreateInstance<Item>();
            window.Show();
            
        }

        private void OnGUI()
        {
            items = Resources.LoadAll("ItemsforRandomizer", typeof(Item));
            if (GUILayout.Button("Random Item"))
            {
                _item = (Item)items[UnityEngine.Random.Range(0, items.Length)];
                Debug.Log("Randomized Item");
                Debug.Log(_item.Name);                
            }
            if(_item != null)
                GUILayout.Label(_item.Name);
        }        
    }
}