using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Konu : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            int whichScene = SceneManager.GetActiveScene().buildIndex;
            if (whichScene == 0)
            {
                SceneManager.LoadScene(6);
            }
            else if(whichScene == 6)
            {
                SceneManager.LoadScene(0);
            }
        } 
    }
}
