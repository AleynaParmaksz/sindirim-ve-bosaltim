using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(BackToMain());  
    }


    void Update()
    {
        
    }

    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }

    public void CreditMenu()
    {
        SceneManager.LoadScene(2);
    }

    public void SolunumSistemiModelMenu()
    {
        SceneManager.LoadScene(3);
    }

    public void ModelTargetMenu()
    {
        SceneManager.LoadScene(4);
    }

    public void CreditsMenu()
    {
        SceneManager.LoadScene(5);
    }

    public void KonuMenu()
    {
        SceneManager.LoadScene(6);
    } 

    IEnumerator BackToMain()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(0);

    }

   



}
