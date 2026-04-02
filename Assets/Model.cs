using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Model : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            int whichScene = SceneManager.GetActiveScene().buildIndex;
            if (whichScene == 0)
            {
                SceneManager.LoadScene(4);
            }
            else if (whichScene == 4)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
