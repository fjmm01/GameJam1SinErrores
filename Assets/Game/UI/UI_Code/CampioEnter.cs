using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CampioEnter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("MP_2");
        }
    }
}
