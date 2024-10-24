using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    const string SAVES_PATH = "/Matematika.save";
    public static void save(ScoreManager obj)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + SAVES_PATH;
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(obj);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameData LoadGameManager()
    {

        string path = Application.persistentDataPath + SAVES_PATH;

        if (File.Exists(path))
        {

            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return data;

        }
        else
        {
            Debug.LogError("Save Not Found In" + path);

            return null;
        }


    }

    public static bool SaveExist(string key)
    {

        string path = Application.persistentDataPath + SAVES_PATH;

        return File.Exists(path + key);
    }
}
