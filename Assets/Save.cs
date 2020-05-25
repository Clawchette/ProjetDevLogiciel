using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Save : MonoBehaviour
{
    private GameManager gameManager;

    void Start(){
        gameManager=GameObject.Find("gameManager").GetComponent<GameManager>();
        LoadGame();
        Debug.Log("LoadGame");
    }

    public void SaveGame(){
        BinaryFormatter bf = new BinaryFormatter(); 
	    FileStream file = File.Create(Application.persistentDataPath + "/SaveFile.dat");
        SaveData data = new SaveData();
        data.creditsSaved = gameManager.credits;
        data.vitesseTirSaved = gameManager.vitesseTir;
        data.vitesseDefilementSaved = gameManager.vitesseDefilement;
        data.vitesseDeplacementSaved = gameManager.vitesseDeplacement;
        bf.Serialize(file, data);
        file.Close();
        Debug.Log("Game data saved!");
    }

    public void LoadGame(){
        if (File.Exists(Application.persistentDataPath + "/SaveFile.dat"))
	    {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/SaveFile.dat", FileMode.Open);
            SaveData data = (SaveData)bf.Deserialize(file);
            file.Close();
            gameManager.credits = data.creditsSaved;
            gameManager.vitesseTir = data.vitesseTirSaved;
            gameManager.vitesseDefilement = data.vitesseDefilementSaved;
            gameManager.vitesseDeplacement = data.vitesseDeplacementSaved;
            Debug.Log("Game data loaded!");
	    }
        
    }
}

[Serializable]
class SaveData
{
    public int creditsSaved;
    public float vitesseTirSaved;
    public float vitesseDefilementSaved;
    public float vitesseDeplacementSaved;
}