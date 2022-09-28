using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] Score score;
    [SerializeField] Player player;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text playerText;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        scoreText.text = score.actualScore.ToString();
        playerText.text = "x" +player.playerCurrentLifePoints.ToString();
    }
}
