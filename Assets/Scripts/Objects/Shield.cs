using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{

    [SerializeField] GameObject player;
    [SerializeField] Player playerLife;
    
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            playerLife = player.GetComponent<Player>();
        }
        else
        {
            return;
        }
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if(playerLife.playerCurrentLifePoints >= playerLife.playerMaxLifePoints)
            {
                playerLife.playerCurrentLifePoints += 0;
            }
            else if(playerLife.playerCurrentLifePoints < playerLife.playerMaxLifePoints)
            {
                playerLife.playerCurrentLifePoints += 1;
            }
            
        }

        Destroy(this.gameObject);
    }
}
