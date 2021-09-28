using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnGUI()
    {
        if(GUI.Button(new Rect (10, 100, 100, 30), "Health Up"))
        {
            GameManager.control.health += 10;
        }
        if (GUI.Button(new Rect(10, 140, 100, 30), "Health Down"))
        {
            GameManager.control.health -= 10;
        }
        if (GUI.Button(new Rect(10, 180, 100, 30), "Experience Up"))
        {
            GameManager.control.experience += 10;
        }
        if (GUI.Button(new Rect(10, 220, 115, 30), "Experience Down"))
        {
            GameManager.control.experience -= 10;
        }

        if (GUI.Button(new Rect(10, 260, 115, 30), "Save"))
        {
            GameManager.control.Save();
        }
        if (GUI.Button(new Rect(10, 300, 115, 30), "Load"))
        {
            GameManager.control.Load();
        }
    }
}
