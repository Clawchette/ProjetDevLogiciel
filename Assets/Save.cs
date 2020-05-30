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
        //créé un fichier pour la sauvegarde
	    FileStream file = File.Create(Application.persistentDataPath + "/SaveFile.dat");
        //créé un nouvel objet data de class SaveData dans le fichier à sauvegarder
        SaveData data = new SaveData();
        gameManager=GameObject.Find("gameManager").GetComponent<GameManager>();
        //ajoute les valeurs à sauvegarder dans l'objet data de class SaveData
        credits = gameManager.credits;
        data.creditsSaved = credits;
        vitesseTir = gameManager.vitesseTir;
        data.vitesseTirSaved = vitesseTir;
        vitesseDefilement = gameManager.vitesseDefilement;
        data.vitesseDefilementSaved = vitesseDefilement;
        vitesseDeplacement = gameManager.vitesseDeplacement;
        data.vitesseDeplacementSaved = vitesseDeplacement;
        //serialize 
        bf.Serialize(file, data);
        //ferme le fichier
        file.Close();
        Debug.Log("Game data saved!");
    }

    public void LoadGame(){
        //si un fichier de sauvegarde existe...
        if (File.Exists(Application.persistentDataPath + "/SaveFile.dat"))
	    {
            BinaryFormatter bf = new BinaryFormatter();
            //... il est ouvert...
            FileStream file = File.Open(Application.persistentDataPath + "/SaveFile.dat", FileMode.Open);
            //... et si il y a du texte dedans...
            if (file.Length > 0){
                //... son contenu est deserialisé dans un objet data de class SaveData...
                SaveData data = (SaveData)bf.Deserialize(file);
                //... et le fichier est fermé
                file.Close();
                //les valeurs qui étaient sauvegardées sont mises dans les variables actuelles du jeu 
                gameManager=GameObject.Find("gameManager").GetComponent<GameManager>();
                gameManager.credits = data.creditsSaved;
                gameManager.vitesseTir = data.vitesseTirSaved;
                gameManager.vitesseDefilement = data.vitesseDefilementSaved;
                gameManager.vitesseDeplacement = data.vitesseDeplacementSaved;
                gameManager.score = 0;
                Debug.Log("Game data loaded!");
            }
	    }        
    }
}

//préparation de la class SaveData qui contient les éléments à sauvegarder
[Serializable]
class SaveData
{
    public int creditsSaved;
    public float vitesseTirSaved;
    public float vitesseDefilementSaved;
    public float vitesseDeplacementSaved;
}