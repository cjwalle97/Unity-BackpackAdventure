using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Saver", menuName = "GameState/Savers/PlayerSaver")]
public class PlayerSaver : ScriptableObject {

    private static PlayerSaver _instance;

    public static PlayerSaver Instance {
        get {

            if (!_instance)
            {
                _instance = Resources.FindObjectsOfTypeAll<PlayerSaver>().FirstOrDefault();
            }

            if (!_instance) { _instance = CreateInstance<PlayerSaver>(); }

            return _instance;
        }

        set { }
    }

    public void SavePlayer(Player player, string filename)
    {
        var path = Application.dataPath + "/StreamingAssets/" + filename + ".json";
        var json = JsonUtility.ToJson(player, true);

        File.WriteAllText(path, json);
    }
}
