using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Star : MonoBehaviour
{
    public bool isGrappled;
    public GameObject player;
    public float lifeTime;
    public float timer;
    private void Start()
    {
        DestroyStar();
        timer = 0;
        
    }
    public void DestroyStar()
    {
        Destroy(gameObject,3f);
    }

    private void Update()
    {
        //if (timer > lifeTime)
       // {
         //   player.GetComponent<TesteGrapplingRope>().isGrappling = false;
       // }
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            isGrappled = true;
            player = collision.gameObject;
            
        }
    }
}
