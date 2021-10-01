using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public int sceneToLoad;
    public static SceneController control;

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

    public void SwitchScene(int scene)
    {
        SceneManager.LoadScene(scene);


    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
