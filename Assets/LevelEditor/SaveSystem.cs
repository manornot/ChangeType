using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace PG2 {
    
    [System.Serializable]
    public class LevelData
    {
        public int[,,] levelArray;
    }
    public static class SaveSystem
    {
        public static void SaveLevel(LevelData level)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + "/level.fun";
            FileStream stream = new FileStream(path, FileMode.Create);
            Debug.Log(path);
            //Debug.Log("level Length 0 = " + level.GetLength(0).ToString());
            //Debug.Log("level Length 1 = " + level.GetLength(1).ToString());
            //Debug.Log("level Length 2 = " + level.GetLength(2).ToString());
            string json = JsonUtility.ToJson(level);
            formatter.Serialize(stream, level);
            Debug.Log(json);
            stream.Close();
        }

        public static LevelData LoadLevel()
        {
            string path = Application.persistentDataPath + "/level.fun";
            if (File.Exists(path))
            {
                BinaryFormatter formater = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);
                var level = formater.Deserialize(stream) as LevelData;
                stream.Close();
                return level;
            }else
            {
                Debug.LogError("Save file not found in " + path);
                return null;
            }
        }

        public static LevelData LoadLevel(string path)
        {
            //string path = Application.persistentDataPath + "/level.fun";
            if (File.Exists(path))
            {
                BinaryFormatter formater = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);
                var level = formater.Deserialize(stream) as LevelData;
                stream.Close();
                return level;
            }
            else
            {
                Debug.LogError("Save file not found in " + path);
                return null;
            }
        }

    }
}
