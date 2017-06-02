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

namespace ScriptableObjects
{
    public class ItemEditorScript : EditorWindow
    {
        private Item _item;
        private GUIStyle _header = new GUIStyle();
        private List<Item> _itemList = new List<Item>();

        [MenuItem("Tools/ItemEditor")]
        static void Init()
        {
            var window = EditorWindow.GetWindow(typeof(ItemEditorScript)) as ItemEditorScript;
            if (window == null) return;
            window._item = CreateInstance<Item>();
            window.Show();
            
        }

        private void OnGUI()
        {
            if(GUILayout.Button("Random Item"))
            {
                Debug.Log("Randomized Item");
                Debug.Log(_item.Name);
            }
        }

    }
}