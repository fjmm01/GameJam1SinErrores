using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
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

    private void RestartGame()
    {
        SceneManager.LoadScene("Juego");
    }

    private void GoToMainMenu()
    {
        SceneManager.LoadScene("UI");
    }
}
