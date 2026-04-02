using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class solunum : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            int whichScene = SceneManager.GetActiveScene().buildIndex;
            if (whichScene == 0)
            {
                SceneManager.LoadScene(3);
            }
            else if (whichScene == 3)
            {
                SceneManager.LoadScene(0);
            }
        }
    } 
}
