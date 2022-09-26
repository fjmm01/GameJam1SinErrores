using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambio : MonoBehaviour
{

    public string New;
    public void SceneLoad()
    {
        SceneManager.LoadScene(New);
    }

    public void QuitGame()
    {

        Debug.Log("Salir!");
        Application.Quit();
    
    }

}
