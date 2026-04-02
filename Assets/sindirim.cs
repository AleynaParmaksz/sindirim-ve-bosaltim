using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sindirim : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            int whichScene = SceneManager.GetActiveScene().buildIndex;
            if (whichScene == 0)
            {
                SceneManager.LoadScene(2);
            }
            else if (whichScene == 2)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
