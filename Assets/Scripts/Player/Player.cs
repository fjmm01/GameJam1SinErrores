using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] MoivmientoCamara movCamara;
    public int playerMaxLifePoints;
    public int playerCurrentLifePoints;
    void Start()
    {
        playerCurrentLifePoints = 1;
    }

    
    void Update()
    {
        if(playerCurrentLifePoints <= 0)
        {
            Destroy(gameObject, 2f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacule"))
        {
            Debug.Log("You were Hit");
            movCamara.MoverCamara(5, 5, 0.5f);
            playerCurrentLifePoints -= 1;
        }
    }
}
