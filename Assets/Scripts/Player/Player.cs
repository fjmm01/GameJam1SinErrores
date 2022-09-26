using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int playerMaxLifePoints;
    public int playerCurrentLifePoints;
    void Start()
    {
        playerCurrentLifePoints = 1;
    }

    
    void Update()
    {
        if(playerCurrentLifePoints == 0)
        {
            Destroy(gameObject, 2f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacule"))
        {
            playerCurrentLifePoints -= 1;
        }
    }
}
