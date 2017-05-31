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
namespace Scripts
{
    public class PlayerMonitorEditorScript : EditorWindow
    {
        private PlayerBehaviour _player;
        private Transform _playertransform;       
        private Backpack _backpack;        
        private GUIStyle _header = new GUIStyle();
        private static PlayerMonitorEditorScript _window;

        void OnEnable()
        {
            Debug.Log("add listener");
            EditorApplication.playmodeStateChanged += Init;
        }

        void OnDisable()
        {
            Debug.Log("remove listener");
            EditorApplication.playmodeStateChanged -= Init;
        }


        [MenuItem("Tools/Player Monitor %g")]
        static void Init()
        {
            _window = EditorWindow.GetWindow(typeof(PlayerMonitorEditorScript)) as PlayerMonitorEditorScript;
            _window._playertransform = GameObject.FindWithTag("Player").transform;
            _window._player = _window._playertransform.GetComponent<PlayerBehaviour>();
            _window._backpack = _window._playertransform.GetComponentInChildren<BackpackBehaviour>().Pack;            
            _window.Show();
            PlayerMovementBehaviour.OnPlayerMoved.AddListener(_window.Repaint);
            BackpackBehaviour.OnPackChange.AddListener(_window.Repaint);
        }
        
        void OnDestroy()
        {
            PlayerMovementBehaviour.OnPlayerMoved.RemoveListener(_window.Repaint);
        }
        ////NEEDS WORK
        private void OnGUI()
        {
            string items = "";
            _header.alignment = TextAnchor.MiddleCenter;
            _header.fontSize = 20;
            GUILayout.Space(40);
            GUILayout.Label("Player Monitor", _header);
            GUILayout.Space(20);
            GUILayout.Label(_player.player.Name + " Health(" + _player.player.Health + ")");
            GUILayout.Space(10);
            GUILayout.Label(_player.player.Name + " Mana(" + _player.player.Mana + ")");
            GUILayout.Space(10);
            GUILayout.Label(_player.player.Name + " Position(" + _playertransform.position + ")");


            if(_backpack != null)
                _backpack.Items.ForEach(x => { items += x.Name + "\n"; });
            GUILayout.Space(20);
            GUILayout.Box(items);            
            
            _backpack = _playertransform.GetComponentInChildren<BackpackBehaviour>().Pack;
            _player = _playertransform.GetComponent<PlayerBehaviour>();
        }



    }
}