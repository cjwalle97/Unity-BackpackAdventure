using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class LootTableDataBaseEditorScript : EditorWindow {

    private string _path;
    private List<string> _tables;
    private List<LootTable> _loottables;
    private GUIStyle _header = new GUIStyle();

    private void _populate()
    {
        _path = Application.dataPath + "/Resources/Tables";    
        _tables.AddRange(Directory.GetFiles(_path, "*.assets"));
        //_loottables.AddRange(Resources.LoadAll(_path));
    }

    [MenuItem("Tools/LootTableDataBase")]
    static void Init()
    {
        var _window = EditorWindow.GetWindow(typeof(LootTableDataBaseEditorScript)) as LootTableDataBaseEditorScript;
        _window._tables = new List<string>();
        _window._populate();
        _window.Show();
    }

    private void OnGUI()
    {
        _header.alignment = TextAnchor.MiddleCenter;
        _header.fontSize = 20;
        GUILayout.Space(40);
        GUILayout.Label("LootTable Database", _header);
        GUILayout.Space(40);

    }

    

}
