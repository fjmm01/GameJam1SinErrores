using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] int highScore;
    [SerializeField] Transform player;
    public int actualScore;
    void Start()
    {
        actualScore = 0;
        highScore = PlayerPrefs.GetInt("HighScore", highScore);
    }

    
    void Update()
    {
        if(player != null)
        {
            actualScore = (int)player.position.y;
        }
        else
        {
            return;
        }
       
        if(actualScore > highScore)
        {
            
            PlayerPrefs.SetInt("HighScore", actualScore);
        }
    }
}
