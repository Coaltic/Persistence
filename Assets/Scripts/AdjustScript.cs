using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustScript : MonoBehaviour
{
    //public static AdjustScript control;

    public Text txtCookies;
    public Text txtHealth;
    public Text txtExperience;
    public Text txtScore;
    public Text txtAmmo;
    public Text txtStamina;
    public Text txtMana;

    // Start is called before the first frame update

    /*void Awake()
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
    }*/

    private void OnGUI()
    {

        if (GUI.Button(new Rect(10, 260, 115, 30), "Save"))
        {
            GameManager.control.Save();
        }
        if (GUI.Button(new Rect(10, 300, 115, 30), "Load"))
        {
            GameManager.control.Load();
        }
    }

    public void Update()
    {
        if (GameObject.Find("Cookies") != null)
        {
            txtCookies.text = "Cookies : " + GameManager.control.cookies.ToString();
        }

        if (GameObject.Find("Health") != null)
        {
            txtHealth.text = "Health : " + GameManager.control.health.ToString();
            txtExperience.text = "Experience : " + GameManager.control.experience.ToString();
        }

        if (GameObject.Find("Mana") != null)
        {
            txtMana.text = "Mana : " + GameManager.control.mana.ToString();
            txtScore.text = "Score : " + GameManager.control.score.ToString();
            txtAmmo.text = "Ammo : " + GameManager.control.ammo.ToString();
            txtStamina.text = "Stamina : " + GameManager.control.stamina.ToString();
        }
    }

    public void CookieUpdate()
    {
        GameManager.control.cookies += 1;
        //txtCookies.text = "Cookies : " + GameManager.control.cookies.ToString();
    }

    public void HealthUpdate(int health)
    {
        GameManager.control.health += health;
        txtHealth.text = "Health : " + GameManager.control.health.ToString();
    }

    public void ExperienceUpdate(int experience)
    {
        GameManager.control.experience += experience;
        txtExperience.text = "Experience : " + GameManager.control.experience.ToString();
    }

    public void ScoreUpdate(int score)
    {
        GameManager.control.score += score;
        txtScore.text = "Score : " + GameManager.control.score.ToString();
    }

    public void AmmoUpdate(int ammo)
    {
        GameManager.control.ammo += ammo;
        txtAmmo.text = "Ammo : " + GameManager.control.ammo.ToString();
    }

    public void StaminaUpdate(int stamina)
    {
        GameManager.control.stamina += stamina;
        txtStamina.text = "Stamina : " + GameManager.control.stamina.ToString();
    }

    public void ManaUpdate(int mana)
    {
        GameManager.control.mana += mana;
        txtMana.text = "Mana : " + GameManager.control.mana.ToString();
    }
}
