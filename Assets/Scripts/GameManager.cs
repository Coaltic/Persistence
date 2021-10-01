using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager control;

    public float health;
    public float experience;
    public int cookies;
    public int score;
    public int ammo;
    public int stamina;
    public int mana;

    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }

    

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData();
        data.health = health;
        data.experience = experience;
        data.cookies = cookies;

        data.score = score;
        data.ammo = ammo;
        data.stamina = stamina;
        data.mana = mana;

        bf.Serialize(file, data);
        file.Close();
    }


    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            health = data.health;
            experience = data.experience;
            cookies = data.cookies;
            score = data.score;
            ammo = data.ammo;
            stamina = data.stamina;
            mana = data.mana;

            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);

            //AdjustScript.OnSceneLoaded(scene);

        }
    }

}

[Serializable]
class PlayerData
{

    public float health;
    public float experience;

    public int cookies;

    public int score;
    public int ammo;
    public int stamina;
    public int mana;




}
