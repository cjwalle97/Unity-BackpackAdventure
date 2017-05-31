using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif


//MONITOR PLAYER 
//  - POSITION
//  - PLAYER HEALTH/MANA
//MONITOR BACKPACK
namespace Scripts{

public class PlayerMonitorEditorScript : EditorWindow {

    private Player _player;
    private Backpack _backpack;
    private GUIStyle _header = new GUIStyle();

    private void _populate()
    {
        _player = GameObject.FindWithTag("Player") as Player;     
        _backpack = _player.GetComponentInChildren<BackpackBehaviour>().Pack;
    }

    [MenuItem("Tools/LootTableDataBase")]
    static void Init()
    {
        var _window = EditorWindow.GetWindow(typeof(PlayerMonitorEditorScript)) as PlayerMonitorEditorScript;
        
        _window._populate();
        _window.Show();
    }


    //NEEDS WORK
    private void OnGUI()
    {
        var _window = EditorWindow.GetWindow(typeof(PlayerMonitorEditorScript)) as PlayerMonitorEditorScript;
        _header.alignment = TextAnchor.MiddleCenter;
        _header.fontSize = 20;
        GUILayout.Space(40);
        GUILayout.Label("Player Monitor", _header);
        GUILayout.Space(40);
        GUILayout.Label(_player.Name + " Health(" + _player.Health.ToString() + ")");
        GUILayout.Space(20);
        GUILayout.Label(_player.Name + " Mana(" + _player.Mana.ToString() + ")");
        GUILayout.Space(20);
        GUILayout.Label(_player.Name + " Position(" + _player.GetComponent<Transform>().position + ")");


        string items = "";
        _backpack.Items.ForEach(x => {items += x.Name + "\n";});
        GUILayout.Space(20);
        GUILayout.Box(items);
        _window._populate();
    }

    

}
}