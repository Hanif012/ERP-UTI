using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveSystem {
    
    public static void SavingData(CurrencyManager currencyManager, GameObject VehicleData) {
        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "/saveData.save";
        FileStream stream = new FileStream(path, FileMode.Create);

        SaveData data = new SaveData(currencyManager, VehicleData);

        formatter.Serialize(stream, data);
        stream.Close();
        
    }

    public static SaveData LoadingData() {
        string path = Application.persistentDataPath + "/saveData.save";
        if (File.Exists(path)) {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            if (stream.Length > 0) {
                SaveData data = formatter.Deserialize(stream) as SaveData;
                stream.Close();
                return data;
            } else {
                Debug.LogError("Save file is empty.");
                stream.Close();
                return null;
            }
            
        } else {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
