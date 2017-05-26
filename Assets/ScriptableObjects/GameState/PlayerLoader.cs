using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Loader", menuName = "GameState/Loaders/PlayerLoader")]
public class PlayerLoader : ScriptableObject
{

    private static PlayerLoader _instance;

    public static PlayerLoader Instance
    {
        get
        {
            if (!_instance)
            {
                _instance = Resources.FindObjectsOfTypeAll<PlayerLoader>().FirstOrDefault();
            }

            if (!_instance) { _instance = CreateInstance<PlayerLoader>(); }

            return _instance;
        }

        set { }
    }

    public Player LoadPlayer(string filename)
    {
        var path = Application.dataPath + "/StreamingAssets/" + filename + ".json";
        var json = System.IO.File.ReadAllText(path);
        var player = CreateInstance<Player>();

        JsonUtility.FromJsonOverwrite(json, player);
        return player;
    }

}
