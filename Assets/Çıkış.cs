using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Çıkış : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            int whichScene = SceneManager.GetActiveScene().buildIndex;
            if (whichScene == 0)
            {
                SceneManager.LoadScene(5);
            }
            else if (whichScene == 5)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
