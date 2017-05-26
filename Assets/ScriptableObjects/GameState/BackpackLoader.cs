using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Backpack Loader", menuName = "GameState/Loaders/BackpackLoader")]
public class BackpackLoader : ScriptableObject {

    private static BackpackLoader _instance;

    public static BackpackLoader Instance
    {
        get
        {
            if (!_instance)
            {
                _instance = Resources.FindObjectsOfTypeAll<BackpackLoader>().FirstOrDefault();
            }

            if (!_instance) { _instance = CreateInstance<BackpackLoader>(); }

            return _instance;
        }

        set { }
    }
    
    public Backpack LoadBackpack(string filename)
    {
        var path = Application.dataPath + "/StreamingAssets/" + filename + ".json";
        var json = System.IO.File.ReadAllText(path);
        var backpack = ScriptableObject.CreateInstance<Backpack>();

        JsonUtility.FromJsonOverwrite(json, backpack);
        
        //RETURNS NULL ITEMS AFTER SHUTDOWN OF GAME THEN STARTUP OF GAME
        //  - IF IN GAME, SAVE/LOAD WORKS
        //  - AFTER SHUTDOWN AND RESTART, 'backpack' RETURNS NULL ITEMS
        return backpack;
    }

}
