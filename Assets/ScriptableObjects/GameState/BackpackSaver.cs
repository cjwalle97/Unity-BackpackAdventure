using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="Backpack Saver", menuName = "GameState/Savers/BackpackSaver")]
public class BackpackSaver : ScriptableObject {


    private static BackpackSaver _instance;

    public static BackpackSaver Instance
    {

        get
        {

            if (!_instance)
            {
                _instance = Resources.FindObjectsOfTypeAll<BackpackSaver>().FirstOrDefault();                
            }

            if (!_instance) { _instance = CreateInstance<BackpackSaver>(); }

            return _instance;

        }

        set { }
    }

    public void SaveBackpack(Backpack backpack, string filename)
    {
        var json = JsonUtility.ToJson(backpack, true);
        var path = Application.dataPath + "/StreamingAssets/" + filename + ".json";

        File.WriteAllText(path, json);
    }    
}
