using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Save : MonoBehaviour
{
    private GameManager gameManager;
    private int credits;
    private float vitesseTir;
    private float vitesseDefilement;
    private float vitesseDeplacement;

    public void SaveGame(){
        BinaryFormatter bf = new BinaryFormatter(); 
	    FileStream file = File.Create(Application.persistentDataPath + "/SaveFile.dat");
        SaveData data = new SaveData();
        gameManager=GameObject.Find("gameManager").GetComponent<GameManager>();
        credits = gameManager.credits;
        data.creditsSaved = credits;
        vitesseTir = gameManager.vitesseTir;
        data.vitesseTirSaved = vitesseTir;
        vitesseDefilement = gameManager.vitesseDefilement;
        data.vitesseDefilementSaved = vitesseDefilement;
        vitesseDeplacement = gameManager.vitesseDeplacement;
        data.vitesseDeplacementSaved = vitesseDeplacement;
        bf.Serialize(file, data);
        file.Close();
        Debug.Log("Game data saved!");
    }

    public void LoadGame(){
        if (File.Exists(Application.persistentDataPath + "/SaveFile.dat"))
	    {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/SaveFile.dat", FileMode.Open);
            if (file.Length > 0){
                SaveData data = (SaveData)bf.Deserialize(file);
                file.Close();
                gameManager=GameObject.Find("gameManager").GetComponent<GameManager>();
                gameManager.credits = data.creditsSaved;
                gameManager.vitesseTir = data.vitesseTirSaved;
                gameManager.vitesseDefilement = data.vitesseDefilementSaved;
                gameManager.vitesseDeplacement = data.vitesseDeplacementSaved;
                Debug.Log("Game data loaded!");
            }
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